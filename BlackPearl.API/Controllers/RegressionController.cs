using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlackPearl.Core.Entities;
using BlackPearl.Core.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlackPearl.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors("AllowMyOrigins")]
    public class RegressionController : ControllerBase
    {
        private readonly IRegressionService _regressionService;
        public RegressionController(IRegressionService regressionService)
        {            
            _regressionService = regressionService;
        }

        // GET: api/Regression
        [HttpGet]
        public IEnumerable<RegressionTest> Get()
        {
            var result =  _regressionService.GetTests();
            return result;
        }

        
    }
}
