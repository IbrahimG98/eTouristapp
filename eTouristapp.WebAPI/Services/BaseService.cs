using AutoMapper;
using eTouristapp.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eTouristapp.WebAPI.Services
{
    public class BaseService<T, TSearch,TDatabase> : IService<T, TSearch>  where TDatabase:class
    {
        protected readonly eTourist1Context _touristcontext;
        protected readonly IMapper _mapper;
        public BaseService(eTourist1Context context, IMapper mapper)
        {
            _touristcontext = context;
            _mapper = mapper;
        }

        public static string GenerateSalt()
        {
            var buff = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buff);
            return Convert.ToBase64String(buff);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);

        }
        public Models.Korisnik Authentifikacija(string korisnickoime, string password)
        {
            var user = _touristcontext.Set<Database.Korisnik>().Include("Uloga").FirstOrDefault(x => x.KorisnikoIme == korisnickoime);
            if (user != null)
            {
                var noviHash = GenerateHash(user.LozinkaSalt, password);

                if (noviHash == user.LozinkaHash)
                {
                    return _mapper.Map<Models.Korisnik>(user);
                }
            }
            return null;
        }

        public virtual List<T> Get(TSearch search)
        {
            var list = _touristcontext.Set<TDatabase>().ToList();
            return _mapper.Map<List<T>>(list);
        }

        public virtual T GetById(int id)
        {
            var entitet = _touristcontext.Set<TDatabase>().Find(id);
            return _mapper.Map<T>(entitet);
        }

        

    }
}
