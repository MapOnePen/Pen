using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IdentityModel.Client;

namespace Identity.API.Test.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        public ValuesController()
        {

        }
        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            var discoClient = new DiscoveryClient("http://139.217.11.253:8010") { Policy = { RequireHttps = false } };

            var disco = await discoClient.GetAsync();
            

            var tokenClient = new TokenClient(
               disco.TokenEndpoint,
               "zhou.test",
               "hsL7J6nACUol1916h1yiPygPhxnGFiwA");
            var response = tokenClient.RequestResourceOwnerPasswordAsync("18983039906", "123456", "api1 offline_access").Result;
            

            return new string[] { response.AccessToken, response.RefreshToken };
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
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
