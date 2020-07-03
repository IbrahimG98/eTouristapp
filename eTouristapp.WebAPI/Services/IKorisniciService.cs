using eTouristapp.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore.Infrastructure;
using eTouristapp.Models.Request;

namespace eTouristapp.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<Models.Korisnik> Get(KorisniciSearchRequest request);
        Models.Korisnik GetById(int id);
        Models.Korisnik Insert(KorisniciInsertRequest request);
        Models.Korisnik Update(int id,KorisniciInsertRequest request);

        Models.Korisnik Authentifikacija(string korisnickoime, string pass);
    }
}
