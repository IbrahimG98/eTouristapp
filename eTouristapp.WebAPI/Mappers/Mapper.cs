using AutoMapper;
using eTouristapp.Models;
using eTouristapp.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTouristapp.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnik,Models.Korisnik>();

            CreateMap<Database.Korisnik,KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.Korisnik, Models.Korisnik>().ReverseMap();


            CreateMap<Models.Grad,Database.Grad>(); //stavi database jer nekad ne proradi bez njega,pazi to i za Startup
            CreateMap<Database.Grad, Models.Grad>();
            CreateMap<Database.Destinacija, Models.Destinacija>();
            CreateMap<Database.Destinacija, DestinacijaInsertRequest>().ReverseMap();
            CreateMap<Models.Uloga, Database.Uloga>();
            CreateMap<Database.Uloga, Models.Uloga>();

            CreateMap<Database.Hotel, Models.Hotel>();
            CreateMap<Database.Hotel, HotelInsertRequest>().ReverseMap();
            CreateMap<Database.Hotel, Models.Hotel>().ReverseMap();
            CreateMap<Models.Hotel, HotelInsertRequest>();
            CreateMap<Models.Hotel, HotelInsertRequest>().ReverseMap();

            CreateMap<Database.Termin, Models.Termin>();
            CreateMap<Database.Termin, TerminInsertRequest>().ReverseMap();
            CreateMap<Database.Termin, Models.Termin>().ReverseMap();

            CreateMap<Database.Karta, Models.Karta>();
            CreateMap<Database.Karta, KartaInsertRequest>().ReverseMap();
            CreateMap<Database.Karta, Models.Karta>().ReverseMap();

            CreateMap<Database.Putnik, Models.Putnik>();
            CreateMap<Database.Putnik, PutnikInsertRequest>().ReverseMap();
            CreateMap<Database.Putnik, Models.Putnik>().ReverseMap();

            CreateMap<Database.Ocjena, Models.Ocjena>();
            CreateMap<Database.Ocjena, OcjenaInsertRequest>().ReverseMap();
            CreateMap<Database.Ocjena, Models.Ocjena>().ReverseMap();



        }
        
    }
}
