using DAL;
using System.Collections.Generic;
using System.Web.Http;
using BL;

namespace CSAT.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly PersonService personService = new PersonService();

        // GET api/values
        public List<Person> Get()
        {
            return personService.GetAll();
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

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
