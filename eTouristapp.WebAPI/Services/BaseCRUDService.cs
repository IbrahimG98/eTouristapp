using AutoMapper;
using eTouristapp.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace eTouristapp.WebAPI.Services
{
    public class BaseCRUDService<T, TSearch, TDatabase, TInsert, TUpdate> : BaseService<T, TSearch, TDatabase>, ICRUDService<T, TSearch, TInsert, TUpdate> where TDatabase:class
    {
        public BaseCRUDService(eTourist1Context context, IMapper mapper) : base(context, mapper)
        {
        }

       

        public virtual T Insert(TInsert request)
        {
            var entitet = _mapper.Map<TDatabase>(request);



            _touristcontext.Set<TDatabase>().Add(entitet);
            _touristcontext.SaveChanges();

            return _mapper.Map<T>(entitet);
        }
        [HttpPut]
        public virtual T Update(int id, TUpdate request)
        {
            var entitet = _touristcontext.Set<TDatabase>().Find(id);
            
            _touristcontext.Set<TDatabase>().Attach(entitet);
            _touristcontext.Set<TDatabase>().Update(entitet);
            _mapper.Map(entitet, request);
            _touristcontext.SaveChanges();
            return _mapper.Map<T>(entitet);
        }
        [HttpDelete]
        public virtual bool Delete(int id)
        {
            var entitet = _touristcontext.Set<TDatabase>().Find(id);
            if (entitet != null)
            {
                _touristcontext.Set<TDatabase>().Remove(entitet);
                _touristcontext.SaveChanges();
                return true;

            }
            return false;
        }
    }
}
