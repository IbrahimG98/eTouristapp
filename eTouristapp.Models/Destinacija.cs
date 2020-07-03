using System;
using System.Collections.Generic;
using System.Text;

namespace eTouristapp.Models
{
    public class Destinacija
    {
        public int Id { get; set; }
        public byte[] Slika { get; set; }
        public string Naziv { get; set; }
        public int GradId { get; set; }
        
    }
}
