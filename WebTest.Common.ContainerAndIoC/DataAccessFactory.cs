using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTest.Repositories.Interfaces;
using WebTest.Repositories;

namespace WebTest.Common.ContainerAndIoC
{
    public class PersonRepositoryFactory
    {
        public static IPersonRepository GetPersonRepositoryObj()
        {
            return new PersonRepository();
        }
    }
}
