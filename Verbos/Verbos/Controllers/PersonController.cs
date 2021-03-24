using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Verbos.Model;
using Verbos.Service;

namespace Calculadora.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private readonly IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var user = _personService.FindById(id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public IActionResult PostCreate([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();

            var user = _personService.Create(person);

            return Ok(user);
        }

        [HttpPut]
        public IActionResult PutUpdate([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();

            var user = _personService.Update(person);

            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personService.Delete(id);

            return Ok();
        }
    }
}
