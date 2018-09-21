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
    public class PersonRepository : IPersonRepository
    {
        public PersonRepository() { }
        public List<Person> GetAll()
        {
            using (var personContext = new PersonContext())
            {
                return (personContext.Person.ToList());
            }
        }
        public Person GetByName(string name)
        {
            using (var personContext = new PersonContext())
            {
                return personContext.Person.Where(p => p.Name == name).FirstOrDefault();
            }
        }
    }
}
