using System.Collections.Generic;
using System.Web.Http;

namespace WebApplication.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        static List<string> listNames = new List<string>
        {
            "Anna", "Hanna", "Yuna"
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return listNames;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return listNames[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            listNames.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            listNames[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            listNames.RemoveAt(id);
        }
    }
}
