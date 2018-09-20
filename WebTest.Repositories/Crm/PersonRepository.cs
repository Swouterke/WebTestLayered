using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTest.Model;
using WebTest.Repositories;
using WebTest.Repositories.Interfaces;

namespace WebTest.Repositories
{
    public class PersonRepository
    {
        public PersonRepository() { }
        public List<Person> GetAll()
        {
            using (var personContext = new PersonContext())
            {
                if (personContext.Database.Exists())
                    return (personContext.Person.ToList());
                else
                    return new List<Person>();
            }
        }
    }
}
