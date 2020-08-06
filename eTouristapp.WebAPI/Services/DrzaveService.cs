using AutoMapper;
using eTouristapp.Models.Request;
using eTouristapp.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace eTouristapp.WebAPI.Services
{
    public class DrzaveService : BaseCRUDService<Models.Drzava, DrzavaSearchRequest, Database.Drzava, DrzavaInsertRequest, DrzavaInsertRequest>
    {
        public DrzaveService(eTourist1Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Models.Drzava> Get(DrzavaSearchRequest search)
        {
            var query = _touristcontext.Set<Database.Drzava>().AsQueryable();
            if (search.Naziv != null)
            {
                query = query.Where(x => x.Naziv.Contains(search.Naziv));
            }
            if (search.KontinentId != 0)
            {
                query = query.Where(x => x.KontinentId == search.KontinentId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Models.Drzava>>(list);
        }

        public override Models.Drzava Update(int id, DrzavaInsertRequest request)
        {
            var entitet = _touristcontext.Set<Database.Drzava>().Find(id);
            entitet.Naziv = request.Naziv;
            entitet.KontinentId = request.KontinentId;
            _touristcontext.Set<Database.Drzava>().Attach(entitet);
            _touristcontext.Set<Database.Drzava>().Update(entitet);
            _mapper.Map(entitet, request);
            _touristcontext.SaveChanges();
            return _mapper.Map<Models.Drzava>(entitet);
        }

        public override bool Delete(int id)
        {
            var entitet = _touristcontext.Set<Database.Drzava>().Find(id);
            if (entitet != null)
            {
                _touristcontext.Set<Database.Drzava>().Remove(entitet);
                _touristcontext.SaveChanges();
                return true;

            }
            return false;
        }


    }
}
