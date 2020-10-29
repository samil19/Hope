using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Security;
using Common.DTOs.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private readonly SecurityLogic _securityLogic;
        public SecurityController(SecurityLogic securityLogic)
        {
            _securityLogic = securityLogic;
        }
        // GET: api/<SecurityController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SecurityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SecurityController>
        [HttpPost]
        public IActionResult Post([FromBody] UserDto user)
        {
            try
            {
                _securityLogic.RegistroUsuario(user);
                return StatusCode(201);
            }
            catch(DbUpdateException e)
            {
                if (e.InnerException.Message.Contains("The duplicate key"))
                {
                    if (e.InnerException.Message.Contains("Email"))
                    {
                        return StatusCode(303, "Este Email ya esta siendo utilizado");
                    }
                    else if (e.InnerException.Message.Contains("UserName"))
                    {
                        return StatusCode(303, "Este Usuario ya esta siendo utilizado");
                    }
                }
                
                return StatusCode(500, e.InnerException.Message);
            }
            catch (Exception e)
            {
                return StatusCode(500,e);
            }
        }

        //[HttpPost]
        //public IActionResult LogIn([FromBody] UserDto user)
        //{
        //    try
        //    {
        //        _securityLogic.CheckPassword(1,user.Password);
        //        return Ok();
        //    }
        //    catch (Exception e)
        //    {
        //        return StatusCode(500, e);
        //    }
        //}



        // PUT api/<SecurityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SecurityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
