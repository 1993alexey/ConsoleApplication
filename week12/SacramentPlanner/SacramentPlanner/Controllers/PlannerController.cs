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
    public class PlannerController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "hello", "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public PlannerController(ILogger<PlannerController> logger)
        {

        }

        [HttpGet("GetJunk", Name = "GetJunk")]
        public IEnumerable Get()
        {
            return Summaries;
        }
    }
}
