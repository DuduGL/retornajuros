using Microsoft.AspNetCore.Mvc;
using RetornaJuros.Services.Implementations;
using RetornaJuros.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetornaJuros.Controllers
{
    [ApiController]
    [Route("")]
    public class RetornaJurosController : ControllerBase
    {
        public readonly IRetornaJurosService retornaJurosService;

        public RetornaJurosController(IRetornaJurosService _retornaJurosService)
        {
            retornaJurosService = _retornaJurosService;
        }

        [HttpGet]
        [Route("taxaJuros")]
        public decimal RetornaJuros()
        {
            return retornaJurosService.RetornaJuros();
        }
    }
}
