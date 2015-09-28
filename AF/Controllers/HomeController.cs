using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AF.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cameres()
        {
            return View();
        }

        public ActionResult Fotometres()
        {
            return View();
        }

        public ActionResult Contacte()
        {
            return View();
        }

    }
}