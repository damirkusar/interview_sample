using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication2
{
    public class PersonRepository
    {
        private readonly IList<Person> peopleList;

        public PersonRepository()
        {
            this.peopleList = new List<Person>();
        }

        public IList<Person> GetPeople()
        {
            return this.peopleList;
        }

        public Person GetPerson(Guid id)
        {
            var person = this.peopleList.FirstOrDefault(p => p.Id == id);

            return person;
        }

        public void AddPerson(Person person)
        {
            this.peopleList.Add(person);
        }

        public void DeletePerson(Guid id)
        {
            var person = this.peopleList.FirstOrDefault(p => p.Id == id);

            this.peopleList.Remove(person);
        }

        public void UpdatePerson(Guid id, Person updatedPerson)
        {
            var person = this.peopleList.FirstOrDefault(p => p.Id == id);

            person.FirstName = updatedPerson.FirstName;
            person.LastName = updatedPerson.LastName;
            person.Age = updatedPerson.Age;
        }
    }
}
