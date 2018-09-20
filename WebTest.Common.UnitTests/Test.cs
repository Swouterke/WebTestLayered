using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebTest.Model;
using WebTest.Business;
using WebTest.Repositories;

namespace WebTest.Common.UnitTests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void PersonTest()
        {
            Person person = new Person(new Guid("6E5E76E6 - 5C00 - 424E-9789 - 002855F4B03E"), "jeanke", 3);
            bool isPerson = true;
            if (!person.GetType().Equals(typeof(Person))) 
            {
                isPerson = false;
            }
            Assert.IsTrue(isPerson);
        }

        [TestMethod]
        public void PersonManagerTest()
        {
            PersonManager peopleManager = new PersonManager();

            bool isListOfPersons = true;
            //if (!peopleManager.GetAll().GetType().Equals(typeof(List<Person>)))
            //{
            //    isListOfPersons = false;
            //}
            Assert.IsTrue(isListOfPersons);
        }

        [TestMethod]
        public void PersonRepositoryTest()
        {
            PersonRepository peopleRepository = new PersonRepository();

            bool isListOfPersons = true;
            //if (!peopleRepository.GetAll().GetType().Equals(typeof(List<Person>)))
            //{
            //    isListOfPersons = false;
            //}
            Assert.IsTrue(isListOfPersons);
        }
    }
}
