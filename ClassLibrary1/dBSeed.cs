using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using WebTest.Model;

namespace WebTest.dB
{
    public class dBSeed : DropCreateDatabaseIfModelChanges<PeopleDBContext>
    {
        protected override void Seed(PeopleDBContext context)
        {
            var persons = new List<Person>
            {
                new Person(1, "Pol", 1),
                new Person(2, "Pal", 2),
                new Person(3, "Pul", 3)
            };
            persons.ForEach(s => context.People.Add(s));
            base.Seed(context);
        }
    }
}
