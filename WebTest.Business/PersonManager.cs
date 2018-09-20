using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTest.Model;
using WebTest.Repositories;
using WebTest.Business.Interfaces;

namespace WebTest.Business
{
    public class PersonManager
    {
        private PersonRepository personRepo = new PersonRepository();

        public List<Person> GetAll()
        {
            return personRepo.GetAll();
        }
    }
}
