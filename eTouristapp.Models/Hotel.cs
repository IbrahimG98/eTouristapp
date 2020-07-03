using System;
using System.Collections.Generic;
using System.Text;

namespace eTouristapp.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public byte[] Slika { get; set; }
        public string Naziv { get; set; }
        public int GradId { get; set; }
        public int BrojZvjezdica { get; set; }
        public virtual Grad Grad { get; set; }
    }
}
