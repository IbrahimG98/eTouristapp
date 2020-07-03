using System;
using System.Collections.Generic;
using System.Text;

namespace eTouristapp.Models
{
    public class Putnik
    {
        public int Id { get; set; }
        public int? KorisnikId { get; set; }
        public DateTime? DatumRegistracije { get; set; }
    }
}
