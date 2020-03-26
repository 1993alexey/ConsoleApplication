using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SacramentPlanner.Models;
using SacramentPlanner.Services;

namespace SacramentPlanner.Controllers
{
    // [ApiController]
    [Route("api/[controller]")]
    public class PlannersController : ControllerBase
    {
        private readonly PlannerService _plannerService;

        public PlannersController(PlannerService plannerService)
        {
            _plannerService = plannerService;
        }

        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<PlannerModel>> Get()
        {
            return _plannerService.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<PlannerModel> Get(string id)
        {
            return _plannerService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<PlannerModel> Post([FromBody]PlannerModel title)
        {
            _plannerService.Create(title);
            return CreatedAtRoute("", new { id = title.Id.ToString() }, title);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody]PlannerModel titleIn)
        {
            var title = _plannerService.Get(id);

            if (title == null)
            {
                return NotFound();
            }

            _plannerService.Update(id, titleIn);

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var title = _plannerService.Get(id);

            if (title == null)
            {
                return NotFound();
            }

            _plannerService.Delete(title.Id);

            return NoContent();
        }
    }
}
