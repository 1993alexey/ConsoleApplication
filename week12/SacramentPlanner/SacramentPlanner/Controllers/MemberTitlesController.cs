using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SacramentPlanner.Models;
using SacramentPlanner.Services;

namespace SacramentPlanner.Controllers
{
    [Route("api/[controller]")]
    public class MemberTitlesController : ControllerBase
    {
        private readonly MemberTitleService _titleService;

        public MemberTitlesController(MemberTitleService titleService)
        {
            _titleService = titleService;
        }

        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<MemberTitleModel>> Get()
        {
            return _titleService.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<MemberTitleModel> Get(string id)
        {
            return _titleService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<MemberTitleModel> Post([FromBody]MemberTitleModel title)
        {
            _titleService.Create(title);
            return CreatedAtRoute("", new { id = title.Id.ToString() }, title);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody]MemberTitleModel titleIn)
        {
            var title = _titleService.Get(id);

            if (title == null)
            {
                return NotFound();
            }

            _titleService.Update(id, titleIn);

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var title = _titleService.Get(id);

            if (title == null)
            {
                return NotFound();
            }

            _titleService.Delete(title.Id);

            return NoContent();
        }
    }
}
