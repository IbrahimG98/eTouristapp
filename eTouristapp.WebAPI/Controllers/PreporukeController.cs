using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eTouristapp.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eTouristapp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreporukeController : ControllerBase
    {
        private readonly IPreporukaService _preporukaService;
        private readonly IMapper _mapper;

        public PreporukeController(IPreporukaService service)
        {
            _preporukaService = service;
           
        }

        [HttpGet("{id}")]
        public List<Models.Destinacija>Get(int id)
        {
            return _preporukaService.GetPreporuka(id);
            
        }

    }
}