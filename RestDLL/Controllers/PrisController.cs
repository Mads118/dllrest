using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BilletLibrary;

namespace RestDLL.Controllers
{


    [Route("api")]
    [ApiController]

    

    public class PrisController : ControllerBase
    {
        // GET: api/Pris
        [HttpGet("Bil/Pris")]
        public int GetBilPris()
        {
            var bil = new Bil();

            return bil.Pris();
        }
        
        // GET: api/Pris/
        [HttpGet("Bil/Type")]
        public String GetBilType()
        {
            var bil = new Bil();

            return bil.KøreTøjType();
        }
        
        // POST: api/Pris
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Pris/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
