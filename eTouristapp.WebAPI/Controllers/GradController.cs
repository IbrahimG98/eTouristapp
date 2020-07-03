using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTouristapp.Models;
using eTouristapp.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eTouristapp.WebAPI.Controllers
{
    
    public class GradController : BaseController<Models.Grad, object>
    {
        public GradController(IService<Grad, object> service) : base(service)
        {

        }
    }
}