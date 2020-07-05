using AutoMapper;
using eTouristapp.Models.Request;
using eTouristapp.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTouristapp.WebAPI.Services
{
    public class TerminiService : BaseCRUDService<Models.Termin, TerminSearchRequest, Database.Termin, TerminInsertRequest, TerminInsertRequest>
    {
        public TerminiService(eTourist1Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Models.Termin> Get(TerminSearchRequest search)
        {
            var query = _touristcontext.Set<Database.Termin>().AsQueryable();
            if(search.DestinacijaId!=0)
            {
                query = query.Where(x => x.DestinacijaId == search.DestinacijaId);
            }
            if (search.DatumPolaska !=null )
            {
                query = query.Where(x => x.DatumPolaska >= search.DatumPolaska);
            }
            if (search.DatumDolaska != null)
            {
                query = query.Where(x => x.DatumDolaska <= search.DatumDolaska);
            }

            var list = query.ToList();
            return _mapper.Map<List<Models.Termin>>(list);
        }

        public override Models.Termin Update(int id,TerminInsertRequest insert)
        {
            var entitet = _touristcontext.Set<Database.Termin>().Find(id);
            entitet.AktivanTermin = insert.AktivanTermin;
            entitet.Cijena = insert.Cijena;
            entitet.Popust = insert.Popust;
            entitet.CijenaPopust = insert.CijenaPopust;
            entitet.DatumDolaska = insert.DatumDolaska;
            entitet.DatumPolaska = insert.DatumPolaska;
            entitet.DestinacijaId = insert.DestinacijaId;
            _touristcontext.Set<Database.Termin>().Attach(entitet);
            _touristcontext.Set<Database.Termin>().Update(entitet);
            _mapper.Map(entitet, insert);
            _touristcontext.SaveChanges();
            return _mapper.Map<Models.Termin>(entitet);
        }
    }
}
