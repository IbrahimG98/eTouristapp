using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eTouristapp.Models.Request
{
    public class KontinentInsertRequest
    {
        [Required]
        public string Naziv { get; set; }

    }
}
