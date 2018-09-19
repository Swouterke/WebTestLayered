using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTest.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public Person(int id, string name, int number)
        {
            Id = id;
            Name = name;
            Number = number;
        }
    }
}
