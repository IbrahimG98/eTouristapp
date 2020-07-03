using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTouristapp.WinUI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _service2 = new APIService("Destinacije");//instanciranje svih servisa hoteli,termini..
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtKorisnickoIme.Text;
                APIService.Password = txtPassword.Text;
                await _service.Get<dynamic>(null);
                await _service2.Get<dynamic>(null);
                frmIndex frm = new frmIndex();
                frm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Authentifikacija", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
