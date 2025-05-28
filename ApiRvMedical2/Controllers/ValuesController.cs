using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace ApiRvMedical2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {

            var obj = new { Message = "Hello" };
            return Ok(obj);
        }

        // GET api/values/5
        public string Get(int id)
        {
            var obj = new { Message = "Hello from Web API" };
            return JsonConvert.SerializeObject(obj);
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
