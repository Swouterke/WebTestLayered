using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTest.Model;
using WebTest.Repositories;
using WebTest.Common.ContainerAndIoC;
using WebTest.Repositories.Interfaces;
using WebTest.Business.Interfaces;

namespace WebTest.Business
{
    public class PersonManager : IPersonManager
    {
        private readonly IPersonRepository _personRepository;

        public PersonManager(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public List<Person> GetAll()
        {
            return _personRepository.GetAll();
        }
    }
}
