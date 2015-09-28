using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AF.Controllers
{
    public class CameresController : Controller
    {
        // GET: Cameres
        public ActionResult Index(String Cameres)
        {
            return View();
        }
    }
}