using eTouristapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTouristapp.WebAPI.Services
{
    public interface IPreporukaService
    {

        public List<Destinacija> GetPreporuka(int id);
    }
}
