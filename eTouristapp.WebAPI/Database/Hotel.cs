using System;
using System.Collections.Generic;

namespace eTouristapp.WebAPI.Database
{
    public partial class Hotel
    {
        public Hotel()
        {
            Termin = new HashSet<Termin>();
        }

        public int Id { get; set; }
        public byte[] Slika { get; set; }
        public string Naziv { get; set; }
        public int? GradId { get; set; }
        public int? BrojZvjezdica { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual ICollection<Termin> Termin { get; set; }
    }
}
