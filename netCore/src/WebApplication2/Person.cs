using System;

namespace WebApplication2
{
    public class Person
    {
        public Person()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }
}