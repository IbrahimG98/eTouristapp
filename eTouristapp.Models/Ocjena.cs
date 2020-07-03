using System;
using System.Collections.Generic;
using System.Text;

namespace eTouristapp.Models
{
    public class Ocjena
    {
        public int Id { get; set; }
        public int? KorisnikId { get; set; }
        public int? DestinacijaId { get; set; }
        public int OcjenaUsluge { get; set; }
        public string Komentar { get; set; }
    }
}
