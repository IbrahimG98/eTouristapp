using AutoMapper;
using eTouristapp.Models.Request;
using eTouristapp.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTouristapp.WebAPI.Services
{
    public class GradoviService : BaseCRUDService<Models.Grad, GradoviSearchRequest, Database.Grad, GradoviInsertRequest, GradoviInsertRequest>
    {
        public GradoviService(eTourist1Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Models.Grad> Get(GradoviSearchRequest search)
        {
            var query = _touristcontext.Set<Database.Grad>().AsQueryable();
            if (search.Naziv != null)
            {
                query = query.Where(x => x.Naziv.Contains(search.Naziv));
            }
            if (search.DrzavaId != 0)
            {
                query = query.Where(x => x.DrzavaId == search.DrzavaId);
            }
            var list = query.ToList();
            return _mapper.Map<List<Models.Grad>>(list);
        }

        public override Models.Grad Update(int id, GradoviInsertRequest request)
        {
            var entitet = _touristcontext.Set<Database.Grad>().Find(id);

            _touristcontext.Set<Database.Grad>().Attach(entitet);
            _touristcontext.Set<Database.Grad>().Update(entitet);
            _mapper.Map(entitet, request);
            _touristcontext.SaveChanges();
            return _mapper.Map<Models.Grad>(entitet);
        }

        public override bool Delete(int id)
        {
            var entitet = _touristcontext.Set<Database.Grad>().Find(id);
            if (entitet != null)
            {
                _touristcontext.Set<Database.Grad>().Remove(entitet);
                _touristcontext.SaveChanges();
                return true;

            }
            return false;
        }

    }
}
