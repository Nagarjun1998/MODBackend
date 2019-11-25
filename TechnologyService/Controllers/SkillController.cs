using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechnologyService.Models;
using TechnologyService.Repositories;

namespace TechnologyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]

    public class SkillController : ControllerBase
    {
        private readonly ISkillRepository _repository;

        public SkillController(ISkillRepository repository)
        {
            _repository = repository;
        }
        // GET: api/Skill
        [HttpGet]
        [Route("GetSkills")]
        public IEnumerable<Skill> Get()
        {
            return _repository.GetSkills();
        }

        [Route("GetById/{id}")]
        public Skill GetS(string id)
        {
            return _repository.GetById(id);
        }
        [Route("GetName/{name}")]
        public Skill Get(string name)
        {
            return _repository.GetName(name);
        }

        // POST: api/Skill/Add
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Skill item)
        {
            _repository.Add(item);
            return Ok("Record Added");
        }

        // PUT: api/Skill/5
        [HttpPut("Update")]
        public IActionResult Put(string id, [FromBody] Skill item)
        {
            _repository.Update(item);
            return Ok("Record Update");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(string id)
        {
            _repository.Delete(id);
            return Ok("Record Deleted");
        }
    }
}
