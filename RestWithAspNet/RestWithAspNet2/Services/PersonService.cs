using DAO.Classes;
using Entidades;
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
        #region Private Context Parameter
        private Person _context { get; set; } = new Person();
        #endregion

        #region CRUD Call Methods
        public PersonModel Create(PersonModel person)
        {
            TB_PERSON _person = new TB_PERSON()
            {
                id = 0,
                address = person.Address,
                firstname = person.FirstName,
                lastname = person.LastName,
                gender = person.Gender
            };

            var id = _context.Add(_person);
            person.Id = id;
            return person;
        }

        public void DeleteById(long Id)
        {
            try
            {
                _context.DeleteById(Id);
            }
            catch (Exception)
            {
                return;
            }
        }

        public List<PersonModel> FindAll()
        {
            try
            {
                List<PersonModel> personModels = new List<PersonModel>();
                var persons = _context.All();
                if (persons.Count() > 0)
                {
                    foreach (var item in persons)
                    {
                        PersonModel personLocal = new PersonModel()
                        {
                            Id = item.id,
                            Address = item.address,
                            FirstName = item.firstname,
                            LastName = item.lastname,
                            Gender = item.gender
                        };

                        personModels.Add(personLocal);
                    }
                }

                return personModels;
            }
            catch (Exception)
            {
                return new List<PersonModel>();
            }
        }

        public PersonModel FindById(long Id)
        {
            try
            {
                var person = _context.GetPerson(Id);
                if(person != null)
                    return new PersonModel
                    {
                        Id = person.id,
                        FirstName = person.firstname,
                        LastName = person.lastname,
                        Address = person.address,
                        Gender = person.gender
                    };
                else
                    return new PersonModel();
            }
            catch (Exception)
            {
                return new PersonModel();
            }
        }

        public PersonModel Update(PersonModel person)
        {
            try
            {
                TB_PERSON _person = new TB_PERSON()
                {
                    id = person.Id,
                    address = person.Address,
                    firstname = person.FirstName,
                    lastname = person.LastName,
                    gender = person.Gender
                };

                var retorno = _context.Put(_person);
                if (retorno != null)
                    return person;
                else
                    return new PersonModel();
            }
            catch (Exception)
            {
                return new PersonModel();
            }
        }
        #endregion

        #region Old
            //private PersonModel MockPerson(int i)
            //{
            //    return new PersonModel
            //    {
            //        Id = IncrementAndGet(),
            //        FirstName = "Person Name" + i,
            //        LastName = "Person Last name" + i,
            //        Address = "Some Andress" + i,
            //        Gender = (i % 2) == 0 ?  "Male" : "Female"
            //    };
            //}

            //private long IncrementAndGet()
            //{
            //    return Interlocked.Increment(ref count);
            //}
        #endregion
    }
}
