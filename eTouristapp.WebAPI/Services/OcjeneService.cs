using AutoMapper;
using eTouristapp.Models.Request;
using eTouristapp.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTouristapp.WebAPI.Services
{
    public class OcjeneService : BaseCRUDService<Models.Ocjena, OcjenaSearchRequest, Database.Ocjena, OcjenaInsertRequest, OcjenaInsertRequest>
    {
        public OcjeneService(eTourist1Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Models.Ocjena> Get(OcjenaSearchRequest search)
        {
            var query = _touristcontext.Set<Database.Ocjena>().AsQueryable();
            if (search.DestinacijaID != 0)
            {
                query = query.Where(x => x.DestinacijaId == search.DestinacijaID);
            }
            var list = query.ToList();
            return _mapper.Map<List<Models.Ocjena>>(list);
        }
    }
}
