using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SacramentPlanner.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlannersController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "hello", "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public PlannersController(ILogger<PlannersController> logger)
        {

        }

        [HttpGet("GetJunk", Name = "GetJunk")]
        public IEnumerable Get()
        {
            return Summaries;
        }
    }
}
