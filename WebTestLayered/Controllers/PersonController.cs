using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTestLayered.ViewModels;
using WebTest.Model;
using WebTest.Business;
using WebTest.Business.Interfaces;

namespace WebTestLayered.Controllers
{
    public class PersonController : Controller
    {
        private PersonManager personManager = new PersonManager();

        public ActionResult Index()
        {
            return View(personManager.GetAll());
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