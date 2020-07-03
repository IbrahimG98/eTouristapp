using AutoMapper;
using eTouristapp.Models.Request;
using eTouristapp.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTouristapp.WebAPI.Services
{
    public class KarteService : BaseCRUDService<Models.Karta, KartaSearchRequest, Database.Karta, KartaInsertRequest, KartaInsertRequest>
    {
        public KarteService(eTourist1Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Models.Karta> Get(KartaSearchRequest search)
        {
            var query = _touristcontext.Set<Database.Karta>().AsQueryable();
            if (search.ID != 0)
            {
                query = query.Where(x => x.Id==search.ID);
            }
            if(search.TerminID !=0)
            {
                query = query.Where(x => x.TerminId == search.TerminID);
            }
            if (search.KorisnikID != 0)
            {
                query = query.Where(x => x.KorisnikId == search.KorisnikID);
            }
            var list = query.ToList();
            return _mapper.Map<List<Models.Karta>>(list);
        }


    }
}
