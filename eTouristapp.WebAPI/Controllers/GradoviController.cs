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
    public class GradoviController : BaseCRUDController<Models.Grad, GradoviSearchRequest, GradoviInsertRequest, GradoviInsertRequest>
    {
        public GradoviController(ICRUDService<Grad, GradoviSearchRequest, GradoviInsertRequest, GradoviInsertRequest> service) : base(service)
        {

        }
    }
}