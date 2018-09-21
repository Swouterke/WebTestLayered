using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.Model;
using WebTest.Business.Interfaces;

namespace WebTestLayered.Controllers
{
    public class ScoreController : Controller
    {
        private readonly IPersonManager _personManager;
        public ScoreController (IPersonManager personManager)
        {
            _personManager = personManager;
        }
        // GET: Score
        public ActionResult Index()
        {
            Person person = _personManager.GetByName("Pol");
            if (person != null)
                return View(person);
            else
                return View(new Person());
        }
    }
}