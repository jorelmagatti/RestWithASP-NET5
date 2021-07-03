using DAO.ADO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO.Classes
{
    public class Person
    {
        public long Add(TB_PERSON person)
        {
            try
            {
                using (var contexto = new TemplateContext())
                {
                    contexto.TB_PERSON.Add(person);
                    return contexto.SaveChanges();
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public List<TB_PERSON> All()
        {
            try
            {
                List<TB_PERSON> persons;
                using (var contexto = new TemplateContext())
                {
                    persons = contexto.TB_PERSON.ToList();
                }
                return persons;
            }
            catch (Exception)
            {
                return default;
            }

        }

        public void DeleteById(long id)
        {
            try
            {
                using (var contexto = new TemplateContext())
                {
                    var person = contexto.TB_PERSON.ToList().Where(c => c.id == (id)).FirstOrDefault();
                    contexto.TB_PERSON.Remove(person);
                    contexto.SaveChanges();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public TB_PERSON GetPerson(long id)
        {
            try
            {
                TB_PERSON person;

                using (var contexto = new TemplateContext())
                {
                    person = contexto.TB_PERSON.Where(c => c.id == (id)).FirstOrDefault();
                }

                return person;
            }
            catch (Exception)
            {
                return default;
            }
        }

        public TB_PERSON Put(TB_PERSON person)
        {
            try
            {
                using (var contexto = new TemplateContext())
                {
                    var selPerson = contexto.TB_PERSON.ToList().Where(c => c.id == (person.id)).FirstOrDefault();

                    selPerson.id = person.id;
                    selPerson.address = person.address;
                    selPerson.firstname = person.firstname;
                    selPerson.lastname = person.lastname;
                    selPerson.gender = person.gender;

                    contexto.SaveChanges();
                    return selPerson;

                }
            }
            catch (Exception)
            {
                return new TB_PERSON();
            }
        }
    }
}
