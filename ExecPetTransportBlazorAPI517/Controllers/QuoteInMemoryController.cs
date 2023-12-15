using ExecPetTransportBlazorAPI517.Data;
using ExecPetTransportBlazorAPI517.Models;
using ExecPetTransportBlazorAPI517.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExecPetTransportBlazorAPI517.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class QuoteInMemoryController : ControllerBase
    {
        private readonly IQuoteRepository _quoteRepository;

        public QuoteInMemoryController(QuoteRepository  quoteRepository)
        {
            _quoteRepository = quoteRepository;
                
        }
        // GET: api/<QuoteInMemoryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<QuoteInMemoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<QuoteInMemoryController>
        [HttpPost]
        public async Task<ActionResult<QuoteModel>> CreateQuote(QuoteModel quote)
        {
            Quote q = new Quote();
            //q.id = Guid.NewGuid();
            
            //Owner o = new Owner();
            //o.id = Guid.NewGuid();
            
            //Cat c = new Cat();
            //c.id = Guid.NewGuid();
            
            //Dog d = new Dog();
            //d.id = Guid.NewGuid();
            
            //Trip t = new Trip();
            //t.id = Guid.NewGuid();


            return Ok(q);
        }

        // PUT api/<QuoteInMemoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QuoteInMemoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
