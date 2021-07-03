using RestWithAspNet2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspNet2.Services.Interfaces
{
    public interface IPersonService
    {
        PersonModel Create(PersonModel person);
        PersonModel Update(PersonModel person);
        PersonModel FindById(long Id);
        List<PersonModel> FindAll();
        void DeleteById(long Id);
    }
}
