using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTest.Model;
using WebTest.Repositories.Interfaces;
using WebTest.dB;

namespace WebTest.Repositories
{
    public class PeopleRepository : IRepositoryBase
    {
        private dBManager dbManager = new dBManager();
        public List<Person> GetAll()
        {
            return dbManager.GetAll();
        }
    }
}
