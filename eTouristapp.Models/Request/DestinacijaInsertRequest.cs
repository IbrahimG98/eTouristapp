using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eTouristapp.Models.Request
{
    public class DestinacijaInsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public byte[] Slika { get; set; }
        [Required]
        public int? GradId { get; set; }
    }
}
