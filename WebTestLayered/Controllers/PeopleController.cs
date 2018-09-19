using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTestLayered.ViewModels;
using WebTest.Model;
using WebTest.Business;

namespace WebTestLayered.Controllers
{
    public class PeopleController : Controller
    {
        private PeopleManager peopleManager = new PeopleManager();
        public ActionResult Index()
        {
            List<Person> persons = peopleManager.GetAll();
            return View(persons);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}