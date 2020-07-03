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
    public class OcjeneController : BaseCRUDController<Models.Ocjena, OcjenaSearchRequest, OcjenaInsertRequest, OcjenaInsertRequest>
    {
        public OcjeneController(ICRUDService<Models.Ocjena, OcjenaSearchRequest, OcjenaInsertRequest, OcjenaInsertRequest> service) : base(service)
        {
        }
    }
}