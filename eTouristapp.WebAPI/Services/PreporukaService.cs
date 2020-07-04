using AutoMapper;
using eTouristapp.Models;
using eTouristapp.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTouristapp.WebAPI.Services
{
    public class PreporukaService : IPreporukaService
    {
        private readonly eTourist1Context _context;
        private readonly IMapper _mapper;

        private int PreporucenBroj = 2;

        public PreporukaService(eTourist1Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Models.Destinacija> GetPreporuka(int id)
        {
            List<Models.Destinacija> listapreporucenihdestinacija = new List<Models.Destinacija>();
            List<Models.Destinacija> rezultat = new List<Models.Destinacija>();
            Database.Korisnik korisnik = _context.Korisnik.Find(id);
            if(korisnik!=null)
            {
                var korisnikoveKarte = _context.Karta.Where(l => l.KorisnikId==korisnik.Id).ToList();

                Dictionary<int, int> Angazman = new Dictionary<int, int>();
               
                //var listaOdredista = new List<int>();
                //var listaTermina = new List<int>();
                //var listaVremenaPolaska = new List<DateTime>();
                //var listaKorisnikovihDestinacija = new List<int>();

                var sveDestinacije = _context.Destinacija.ToList();

                
                Dictionary<int, int> destinacijaibrojac = new Dictionary<int, int>();
                foreach(var i in sveDestinacije)
                {
                    var brojac1 = 0;
                    foreach (var item in korisnikoveKarte)
                    {
                        var termin = _context.Termin.Include(x => x.Destinacija).Where(l => l.Id == item.TerminId).FirstOrDefault();

                        var terminmodel = _mapper.Map<Models.Termin>(termin);

                        var destinacija = _context.Destinacija.Where(x => x.Id == termin.Destinacija.Id).FirstOrDefault();
                        //listaKorisnikovihDestinacija.Add(destinacija.Id);
                        if (i.Id == destinacija.Id)
                            brojac1++;

                        //listaOdredista.Add(int.Parse(destinacija.GradId.ToString()));
                        //listaVremenaPolaska.Add(karta.DatumPolaska);


                    }

                    if(!destinacijaibrojac.ContainsKey(i.Id))
                    {
                        destinacijaibrojac.Add(i.Id, brojac1);
                        
                    }


                    
                }
                

                foreach(var k in destinacijaibrojac.ToList())
                {
                    if(k.Value>=PreporucenBroj)
                    {
                        
                        var destinacija = _context.Destinacija.Where(x => x.Id == k.Key).FirstOrDefault();
                        var d = _mapper.Map<Models.Destinacija>(destinacija);
                        rezultat.Add(d);

                    }
                }


                return rezultat;














            }

            return rezultat;
        }
    }
}
