using AutoMapper;
using eTouristapp.Models;
using eTouristapp.Models.Request;
using eTouristapp.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTouristapp.WebAPI.Services
{
    public class KontinentiService : BaseCRUDService<Models.Kontinent, KontinentSearchRequest, Database.Kontinent, KontinentInsertRequest, KontinentInsertRequest>
    {
        public KontinentiService(eTourist1Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Models.Kontinent> Get(KontinentSearchRequest search)
        {
            var query = _touristcontext.Set<Database.Kontinent>().AsQueryable();
            if (search.Naziv != null)
            {
                query = query.Where(x => x.Naziv.Contains(search.Naziv));
            }
           
            var list = query.ToList();
            return _mapper.Map<List<Models.Kontinent>>(list);
        }


        public override Models.Kontinent Update(int id, KontinentInsertRequest request)
        {
            var entitet = _touristcontext.Set<Database.Kontinent>().Find(id);
            entitet.Naziv = request.Naziv;
            _touristcontext.Set<Database.Kontinent>().Attach(entitet);
            _touristcontext.Set<Database.Kontinent>().Update(entitet);
            _mapper.Map(entitet, request);
            _touristcontext.SaveChanges();
            return _mapper.Map<Models.Kontinent>(entitet);
        }

        public override bool Delete(int id)
        {
            var entitet = _touristcontext.Set<Database.Kontinent>().Find(id);
            if (entitet != null)
            {
                _touristcontext.Set<Database.Kontinent>().Remove(entitet);
                _touristcontext.SaveChanges();
                return true;

            }
            return false;
        }
    }
}
