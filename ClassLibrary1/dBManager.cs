using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTest.Model;

namespace WebTest.dB
{
    public class dBManager
    {
        public List<Person> GetAll()
        {
            return new List<Person>
            {
                new Person(1, "Pol", 1),
                new Person(2, "Pal", 2),
                new Person(3, "Pul", 3)
            };
        }
    }
}
