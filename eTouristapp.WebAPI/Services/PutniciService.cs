using AutoMapper;
using eTouristapp.Models.Request;
using eTouristapp.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTouristapp.WebAPI.Services
{
    public class PutniciService : BaseCRUDService<Models.Putnik, PutnikSearchRequest, Database.Putnik, PutnikInsertRequest, PutnikInsertRequest>
    {
        public PutniciService(eTourist1Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Models.Putnik> Get(PutnikSearchRequest search)
        {
            var query = _touristcontext.Set<Database.Putnik>().AsQueryable();
            
            query = query.Where(x=>x.Id == search.ID);
            
            var list = query.ToList();
            return _mapper.Map<List<Models.Putnik>>(list);
        }
    }
}
