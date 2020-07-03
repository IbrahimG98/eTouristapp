using System;
using System.Collections.Generic;

namespace eTouristapp.WebAPI.Database
{
    public partial class Putnik
    {
        public int Id { get; set; }
        public int? KorisnikId { get; set; }
        public DateTime? DatumRegistracije { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}
