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
    public class MembersController : ControllerBase
    {
        private readonly MemberService _memberService;
        public MembersController(MemberService memberService)
        {
            _memberService = memberService;
        }

        // GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<MemberModel>> Get()
        {
            return _memberService.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<MemberModel> Get(string id)
        {
            return _memberService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<MemberModel> Post([FromBody]MemberModel title)
        {
            _memberService.Create(title);
            return CreatedAtRoute("", new { id = title.Id.ToString() }, title);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody]MemberModel titleIn)
        {
            var title = _memberService.Get(id);

            if (title == null)
            {
                return NotFound();
            }

            _memberService.Update(id, titleIn);

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var title = _memberService.Get(id);

            if (title == null)
            {
                return NotFound();
            }

            _memberService.Delete(title.Id);

            return NoContent();
        }
    }
}
