using RestWithAspNet2.Model;
using RestWithAspNet2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithAspNet2.Services
{
    public class PersonService : IPersonService
    {
        private volatile int count;

        public PersonModel Create(PersonModel person)
        {
            return person;
        }

        public void DeleteById(long Id)
        {
            return;
        }

        public List<PersonModel> FindAll()
        {
            List<PersonModel> persons = new List<PersonModel>();
            for (int i = 0; i < 8; i++)
            {
                PersonModel person = MockPerson(i);
                persons.Add(person);
            }



            return persons;
        }


        public PersonModel FindById(long Id)
        {
            return new PersonModel
            {
                Id = IncrementAndGet(),
                FirstName = "Jorel",
                LastName = "magatti da  Silva",
                Address = "rua Dominguinhos, S/n Jardim Santo André",
                Gender = "Male"
            };
        }

        public PersonModel Update(PersonModel person)
        {
            return person;
        }

        private PersonModel MockPerson(int i)
        {
            return new PersonModel
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person Last name" + i,
                Address = "Some Andress" + i,
                Gender = (i % 2) == 0 ?  "Male" : "Female"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
