using System;
using System.Collections.Generic;
using System.Text;

namespace eTouristapp.Models.Request
{
    public class PutnikInsertRequest
    {

        public int? KorisnikId { get; set; }
        public DateTime? DatumRegistracije { get; set; }
    }
}
