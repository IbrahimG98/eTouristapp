using System;
using System.Collections.Generic;
using System.Text;

namespace eTouristapp.Models.Request
{
    public class KartaSearchRequest
    {
        public int ID { get; set; }
        public int TerminID { get; set; }
        public int KorisnikID { get; set; }
    }
}
