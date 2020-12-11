using System.Collections.Generic;
using Devon4Net.Infrastructure.Log;
using Microsoft.AspNetCore.Mvc;

namespace Devon4Net.Application.WebAPI.AwsServerless.Business.Values.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            Devon4NetLogger.Debug($"Received post value {value}");
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            Devon4NetLogger.Debug($"Received put value {value}");
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Devon4NetLogger.Debug($"Received delete value {id}");
        }
    }
}
