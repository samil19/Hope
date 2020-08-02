using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Personas;
using Common.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class PersonaController : ControllerBase
    {
        private readonly PersonasLogic _personasLogic;
        public PersonaController(PersonasLogic personasLogic)
        {
            _personasLogic = personasLogic;
        }
        // GET: api/<PersonaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PersonaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonaController>
        [HttpPost]
        public IActionResult Post([FromBody] PersonaDto data)
        {
            _personasLogic.Insert(data);
            return Ok();
        }

        // PUT api/<PersonaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
