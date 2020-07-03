using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTouristapp.WebAPI.Services
{
    public interface IService<T,TSearch>
    {
        List<T> Get(TSearch search);
       T GetById(int id);
        //Models.Korisnik Authentifikacija(string korisnickoime, string pass);
    }
}
