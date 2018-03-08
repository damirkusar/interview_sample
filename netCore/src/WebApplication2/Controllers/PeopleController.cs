using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        private PersonRepository repository;

        public PeopleController()
        {
            this.repository = new PersonRepository();
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return this.repository.GetPeople();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Person Get(Guid id)
        {
            return this.repository.GetPerson(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Person person)
        {
            if (string.IsNullOrEmpty(person.FirstName) || string.IsNullOrEmpty(person.LastName) || person.Age == 0)
            {
                return;
            }

            this.repository.AddPerson(person);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]Person person)
        {
            if (string.IsNullOrEmpty(person.FirstName) || string.IsNullOrEmpty(person.LastName) || person.Age == 0)
            {
                return;
            }

            this.repository.UpdatePerson(id, person);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            this.repository.DeletePerson(id);
        }
    }
}
