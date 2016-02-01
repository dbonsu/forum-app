using ForumApp.Services.Interfaces;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace ForumApp.Controllers
{
    public class ValuesController : ApiController
    {
        private IFakeService _fakeService;

        public ValuesController(IFakeService service)
        {
            _fakeService = service;
        }

        [HttpDelete]
        [Route("api/values/del")]
        public void Endpoint()
        {
            _fakeService.GrabAFakeModel();
        }

        [Route("api/values/testfake")]
        [HttpGet]
        public string Fake()
        {
            return "hello derick";
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }
    }
}