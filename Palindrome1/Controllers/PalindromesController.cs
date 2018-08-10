using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace Palindrome1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Palindrome1Controller : ControllerBase
    {
        // GET api/pal
        [HttpGet]
        public ActionResult<string> Get()
        {
            

            string[] pal = {"A but tuba",
                                    "A car, a man, a maraca",
                                    "A dog has a plan, a canal: pagoda",
                                    "A dog! A panic in a pagoda!",
                                    "A lad named E. Mandala",
                                    "A man is a man, a plan is a plan, a canal is in Panama",
                                    "A new order began, a more Roman age bred Rowena",
                                    "A nut for a jar of tuna",
                                    "A Santa at Nasa is Clause",
                                    "A Santa dog lived as a devil God at NASA",
                                    "A slut nixes sex in Tulsa"};
            
            return new ObjectResult(new Palindromes { palindrome = pal } );


        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
