using System;
using System.Collections.Generic;

namespace eTouristapp.WebAPI.Database
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            Karta = new HashSet<Karta>();
            Ocjena = new HashSet<Ocjena>();
            Putnik = new HashSet<Putnik>();
            Uposlenik = new HashSet<Uposlenik>();
        }

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnikoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public byte[] Slika { get; set; }
        public string Email { get; set; }
        public int? UlogaId { get; set; }

        public virtual Uloga Uloga { get; set; }
        public virtual ICollection<Karta> Karta { get; set; }
        public virtual ICollection<Ocjena> Ocjena { get; set; }
        public virtual ICollection<Putnik> Putnik { get; set; }
        public virtual ICollection<Uposlenik> Uposlenik { get; set; }
    }
}
