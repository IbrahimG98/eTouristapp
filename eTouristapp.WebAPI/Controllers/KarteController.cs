using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTouristapp.Models;
using eTouristapp.Models.Request;
using eTouristapp.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eTouristapp.WebAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class KarteController : BaseCRUDController<Models.Karta, KartaSearchRequest, KartaInsertRequest, KartaInsertRequest>
    {
        public KarteController(ICRUDService<Karta, KartaSearchRequest, KartaInsertRequest, KartaInsertRequest> service) : base(service)
        {

        }
    }
}