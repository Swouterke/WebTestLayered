using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebTest.Model;

namespace WebTest.dB
{
    public class PeopleDBContext : DbContext
    {
        public PeopleDBContext() : base("PeopleDb")
        {
        }

        public DbSet<Person> People {get;set;}       
    }
}
