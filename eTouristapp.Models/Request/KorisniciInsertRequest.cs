using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eTouristapp.Models.Request
{
    public class KorisniciInsertRequest
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Ime { get; set; }
        [Required]
        [MinLength(2)]
        public string Prezime { get; set; }
        [Required]
        [MinLength(3)]
        public string KorisnikoIme { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int? UlogaId { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        public string Password { get; set; }
        [Required(AllowEmptyStrings =false)]
        public string PasswordPotvrda { get; set; }
    }
}
