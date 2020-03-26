using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SacramentPlanner.Models;
using SacramentPlanner.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SacramentPlanner.Controllers
{
    [Route("api/[controller]")]
    public class HymnsController : Controller
    {
        private readonly HymnService _hymnService;
        public HymnsController(HymnService hymnService)
        {
            _hymnService = hymnService;
        }

        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<HymnModel>> Get()
        {
            return _hymnService.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<HymnModel> Get(string id)
        {
            return _hymnService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<HymnModel> Post([FromBody]HymnModel title)
        {
            _hymnService.Create(title);
            return CreatedAtRoute("", new { id = title.Id.ToString() }, title);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody]HymnModel titleIn)
        {
            var title = _hymnService.Get(id);

            if (title == null)
            {
                return NotFound();
            }

            _hymnService.Update(id, titleIn);

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var title = _hymnService.Get(id);

            if (title == null)
            {
                return NotFound();
            }

            _hymnService.Delete(title.Id);

            return NoContent();
        }
    }
}
