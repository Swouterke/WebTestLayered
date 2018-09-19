using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTest.Model;
using WebTest.Repositories;

namespace WebTest.Business
{
    public class PeopleManager
    {
        PeopleRepository peopleRepository = new PeopleRepository();

        public List<Person> GetAll()
        {
            return peopleRepository.GetAll();
        }
    }
}
