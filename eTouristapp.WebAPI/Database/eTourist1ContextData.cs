using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eTouristapp.WebAPI.Database
{
    public partial class eTourist1Context
    {
        public static string GenerateSalt()
        {
            var buff = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buff);
            return Convert.ToBase64String(buff);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);

        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            WebAPI.Database.Kontinent kontinent = new WebAPI.Database.Kontinent()
            {
                Id=1,
                Naziv="Evropa"

            };
            modelBuilder.Entity<Kontinent>().HasData(kontinent);

            WebAPI.Database.Kontinent kontinent2 = new WebAPI.Database.Kontinent()
            {
                Id = 2,
                Naziv = "Afrika"

            };
            modelBuilder.Entity<Kontinent>().HasData(kontinent2);

            WebAPI.Database.Uloga uloga = new WebAPI.Database.Uloga()
            {
                Id=1,
                Naziv="Putnik"

            };
            modelBuilder.Entity<Uloga>().HasData(uloga);

            WebAPI.Database.Uloga uloga2 = new WebAPI.Database.Uloga()
            {
                Id = 2,
                Naziv = "Uposlenik"

            };
            modelBuilder.Entity<Uloga>().HasData(uloga2);

            WebAPI.Database.Drzava drzava = new WebAPI.Database.Drzava()
            {
                Id=1,
                Naziv="Austrija",
                KontinentId=1

            };

            modelBuilder.Entity<Drzava>().HasData(drzava);

            WebAPI.Database.Drzava drzava2 = new WebAPI.Database.Drzava()
            {
                Id = 2,
                Naziv = "Spanija",
                KontinentId = 1

            };

            modelBuilder.Entity<Drzava>().HasData(drzava2);

            WebAPI.Database.Grad grad = new WebAPI.Database.Grad()
            {
               Id=1,
               DrzavaId=1,
               Naziv="Vienna"

            };

            modelBuilder.Entity<Grad>().HasData(grad);

            WebAPI.Database.Grad grad2 = new WebAPI.Database.Grad()
            {
                Id = 2,
                DrzavaId = 2,
                Naziv = "Madrid"

            };

            modelBuilder.Entity<Grad>().HasData(grad2);

            WebAPI.Database.Hotel hotel = new WebAPI.Database.Hotel()
            {
               Id=1,
               Naziv="Hotel Madrid",
               BrojZvjezdica=5,
               GradId=2,
               Slika=File.ReadAllBytes("img/hotel.jpg")
               

            };
            modelBuilder.Entity<Hotel>().HasData(hotel);

            WebAPI.Database.Hotel hotel2 = new WebAPI.Database.Hotel()
            {
                Id = 2,
                Naziv = "Hotel Vienna",
                BrojZvjezdica = 4,
                GradId = 1,
                Slika = File.ReadAllBytes("img/hotel.jpg")


            };
            modelBuilder.Entity<Hotel>().HasData(hotel2);


            WebAPI.Database.Destinacija destinacija = new WebAPI.Database.Destinacija()
            {
                Id=1,
                Naziv="Putovanje u Madrid",
                GradId=2,
                Slika=File.ReadAllBytes("img/madrid.jpg")

            };
            modelBuilder.Entity<Destinacija>().HasData(destinacija);
            WebAPI.Database.Destinacija destinacija2 = new WebAPI.Database.Destinacija()
            {
                Id = 2,
                Naziv = "Putovanje u Madrid2",
                GradId = 2,
                Slika = File.ReadAllBytes("img/madrid.jpg")

            };
            modelBuilder.Entity<Destinacija>().HasData(destinacija2);
            WebAPI.Database.Destinacija destinacija3 = new WebAPI.Database.Destinacija()
            {
                Id = 3,
                Naziv = "Putovanje u Vienna",
                GradId = 1,
                Slika = File.ReadAllBytes("img/vienna.jpg")

            };
            modelBuilder.Entity<Destinacija>().HasData(destinacija3);
            WebAPI.Database.Destinacija destinacija4 = new WebAPI.Database.Destinacija()
            {
                Id = 4,
                Naziv = "Putovanje u Vienna2",
                GradId = 1,
                Slika = File.ReadAllBytes("img/vienna.jpg")

            };
            modelBuilder.Entity<Destinacija>().HasData(destinacija4);

            WebAPI.Database.Termin termin = new WebAPI.Database.Termin()
            {
                Id=1,
                DestinacijaId=1,
                AktivanTermin=true,
                Cijena=1100,
                CijenaPopust=0,
                Popust=0,
                HotelId=1,
                GradId=2,
                DatumPolaska=new DateTime(2020,07,15),
                DatumDolaska=new DateTime(2020,07,20)

            };
            modelBuilder.Entity<Termin>().HasData(termin);

            WebAPI.Database.Termin termin2 = new WebAPI.Database.Termin()
            {
                Id = 2,
                DestinacijaId = 1,
                AktivanTermin = true,
                Cijena = 900,
                CijenaPopust = 0,
                Popust = 0,
                HotelId = 1,
                GradId = 2,
                DatumPolaska = new DateTime(2020,08,02),
                DatumDolaska = new DateTime(2020,08,09)

            };
            modelBuilder.Entity<Termin>().HasData(termin2);

            WebAPI.Database.Termin termin3 = new WebAPI.Database.Termin()
            {
                Id = 3,
                DestinacijaId = 2,
                AktivanTermin = true,
                Cijena = 1200,
                CijenaPopust = 0,
                Popust = 0,
                HotelId = 1,
                GradId = 2,
                DatumPolaska = new DateTime(2020,07,19),
                DatumDolaska = new DateTime(2020,07,27)

            };
            modelBuilder.Entity<Termin>().HasData(termin3);

            WebAPI.Database.Termin termin4 = new WebAPI.Database.Termin()
            {
                Id = 4,
                DestinacijaId = 2,
                AktivanTermin = true,
                Cijena = 1300,
                CijenaPopust = 0,
                Popust = 0,
                HotelId = 1,
                GradId = 2,
                DatumPolaska = new DateTime(2020, 07, 25),
                DatumDolaska = new DateTime(2020, 08, 02)

            };
            modelBuilder.Entity<Termin>().HasData(termin4);

            WebAPI.Database.Termin termin5 = new WebAPI.Database.Termin()
            {
                Id = 5,
                DestinacijaId = 3,
                AktivanTermin = true,
                Cijena = 1200,
                CijenaPopust = 0,
                Popust = 0,
                HotelId = 2,
                GradId = 1,
                DatumPolaska = new DateTime(2020, 07, 15),
                DatumDolaska = new DateTime(2020, 07, 22)

            };
            modelBuilder.Entity<Termin>().HasData(termin5);
            WebAPI.Database.Termin termin6 = new WebAPI.Database.Termin()
            {
                Id = 6,
                DestinacijaId = 3,
                AktivanTermin = true,
                Cijena = 1150,
                CijenaPopust = 0,
                Popust = 0,
                HotelId = 2,
                GradId = 1,
                DatumPolaska = new DateTime(2020, 07, 25),
                DatumDolaska = new DateTime(2020, 07, 30)

            };
            modelBuilder.Entity<Termin>().HasData(termin6);

            WebAPI.Database.Termin termin7 = new WebAPI.Database.Termin()
            {
                Id = 7,
                DestinacijaId = 4,
                AktivanTermin = true,
                Cijena = 1350,
                CijenaPopust = 0,
                Popust = 0,
                HotelId = 2,
                GradId = 1,
                DatumPolaska = new DateTime(2020, 07, 20),
                DatumDolaska = new DateTime(2020, 07, 30)

            };
            modelBuilder.Entity<Termin>().HasData(termin7);


            WebAPI.Database.Korisnik korisnik = new WebAPI.Database.Korisnik()
            {
                Id=1,
                Ime="desktopuser",
                Prezime= "desktopuser",
                KorisnikoIme="desktop",
                Email= "desktop@gmail.com",
                UlogaId=2
                

            };
            korisnik.LozinkaSalt = GenerateSalt();
            korisnik.LozinkaHash = GenerateHash(korisnik.LozinkaSalt, "desktop");
            modelBuilder.Entity<Korisnik>().HasData(korisnik);

            WebAPI.Database.Korisnik korisnik2 = new WebAPI.Database.Korisnik()
            {
                Id = 2,
                Ime = "mobileuser",
                Prezime = "mobileuser",
                KorisnikoIme = "mobile",
                Email = "mobile@gmail.com",
                UlogaId = 1


            };
            korisnik2.LozinkaSalt = GenerateSalt();
            korisnik2.LozinkaHash = GenerateHash(korisnik2.LozinkaSalt, "mobile");
            modelBuilder.Entity<Korisnik>().HasData(korisnik2);



        }
    }
}
