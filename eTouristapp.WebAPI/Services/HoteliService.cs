using eTouristapp.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTouristapp.WebAPI.Services;
using eTouristapp.WebAPI.Database;
using AutoMapper;

namespace eTouristapp.WebAPI.Services
{
    public class HoteliService : BaseCRUDService<Models.Hotel, HotelSearchRequest, Database.Hotel, HotelInsertRequest, HotelInsertRequest>
    {
        public HoteliService(eTourist1Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Models.Hotel> Get(HotelSearchRequest search)
        {
            var query = _touristcontext.Set<Database.Hotel>().AsQueryable();

            if (search.GradId != null)
            {
                query = query.Where(x => x.GradId == search.GradId);
            }

            if (search.Naziv != null)
            {
                query = query.Where(x => x.Naziv.Contains(search.Naziv));
            }


            var list = query.ToList();
            return _mapper.Map<List<Models.Hotel>>(list);
        }

        public override Models.Hotel Update(int id, HotelInsertRequest request)
        {
            var entitet = _touristcontext.Set<Database.Hotel>().Find(id);
            entitet.Naziv = request.Naziv;
            entitet.GradId = request.GradId;
            entitet.BrojZvjezdica = request.BrojZvjezdica;
            //entitet.Slika = request.Slika;
            _touristcontext.Set<Database.Hotel>().Attach(entitet);
            _touristcontext.Set<Database.Hotel>().Update(entitet);
            _mapper.Map(entitet, request);
            _touristcontext.SaveChanges();
            return _mapper.Map<Models.Hotel>(entitet);
        }
    }
}
