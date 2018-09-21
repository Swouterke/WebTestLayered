using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTest.Model;

namespace WebTest.Business.Interfaces
{
    public interface IPersonManager
    {
        List<Person> GetAll();
        Person GetByName(string name);
    }
}
