using System;
using System.Collections.Generic;
using System.Text;

namespace eTouristapp.Models
{
    public class Drzava
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int? KontinentId { get; set; }
    }
}
