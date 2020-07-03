using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using eTouristapp.Models;
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms;
using eProdaja.Mobile;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;
using eTouristapp.Models.Request;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using eTouristapp.Mobile.Views;

namespace eTouristapp.Mobile.ViewModels
{
    public class DestinacijeViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("Destinacije");
        private readonly APIService _gradoviservice = new APIService("Grad");
        public DestinacijeViewModel()
        {
            Initial = new Command(async()=>await Init());
        }

        Grad _selectedGrad = null;
        public Grad SelectedGrad
        {
            get { return _selectedGrad; }
            set { SetProperty(ref _selectedGrad, value); 

                if(value!=null)
                {
                    Initial.Execute(null);
                }
            }
            
        }
        Destinacija _selectedDestinacija = null;
        public Destinacija SelectedDestinacija
        {
            get { return _selectedDestinacija; }
            set
            {
                SetProperty(ref _selectedDestinacija, value);

                //if (value != null)
                //{
                //    Initial.Execute(null);
                //}
            }

        }


        public ObservableCollection<Destinacija> DestinacijeList { get; set; } = new ObservableCollection<Destinacija>();
        public ObservableCollection<Grad> GradoviList { get; set; } = new ObservableCollection<Grad>();
        public ICommand Initial { get; set; }


       
       

        public async Task Init()
        {
            if(GradoviList.Count==0)
            {
                var gradovilist = await _gradoviservice.Get<IEnumerable<Grad>>(null);

                

                foreach (var grad in gradovilist)
                {
                    GradoviList.Add(grad);
                }
            }

            if(SelectedGrad!=null)
            {
                DestinacijaSearchRequest search = new DestinacijaSearchRequest();
                search.Id = SelectedGrad.Id;
                search.Naziv = SelectedGrad.Naziv;

                var list = await _service.Get<IEnumerable<Destinacija>>(search);

                DestinacijeList.Clear();

                foreach (var destinacija in list)
                {
                    DestinacijeList.Add(destinacija);
                }
            }

           


        }
    }
}
