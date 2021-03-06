using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.interfaces;
using api.Model;
namespace api.Controllers
{
    [Route("api/[controller]")]
    [apiController]
    public class personController : ControllerBase
    {
        // GET: api/person
        [HttpGet]
        public IEnumerable<string> Get()
        {
            IPersonDataHandler dataHandler = new PersonDataHandler();
            return dataHandler.Select();
        }

        // GET: api/person/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/person
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/person/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/person/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
