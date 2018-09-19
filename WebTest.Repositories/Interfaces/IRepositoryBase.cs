using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTest.Model;

namespace WebTest.Repositories.Interfaces
{
    interface IRepositoryBase
    {
        List<Person> GetAll();
    }
}
