using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarMechanicLibrary.Models;


namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardataModel : ControllerBase
    {
        // GET: api/<CardataModel>
        [HttpGet]
        public IEnumerable<Cardata> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CardataModel>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CardataModel>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CardataModel>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CardataModel>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
