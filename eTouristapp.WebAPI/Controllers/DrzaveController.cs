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
    public class DrzaveController : BaseCRUDController<Drzava, DrzavaSearchRequest, DrzavaInsertRequest, DrzavaInsertRequest>
    {
        public DrzaveController(ICRUDService<Drzava, DrzavaSearchRequest, DrzavaInsertRequest, DrzavaInsertRequest> service) : base(service)
        {
        }


    }
}