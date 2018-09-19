using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebTest.Model;
using WebTest.Business;

namespace WebTest.Common.UnitTests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void PersonTest()
        {
            Person person = new Person(4, "jeanke", 3);
            bool isPerson = true;
            if (!person.GetType().Equals(typeof(Person))) 
            {
                isPerson = false;
            }
            Assert.IsTrue(isPerson);
        }

        [TestMethod]
        public void ListPersonTest()
        {
            PeopleManager peopleManager = new PeopleManager();

            bool isListOfPersons = true;
            if (!peopleManager.GetAll().GetType().Equals(typeof(List<Person>)))
            {
                isListOfPersons = false;
            }
            Assert.IsTrue(isListOfPersons);
        }
    }
}
