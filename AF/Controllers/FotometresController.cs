using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AF.Controllers
{
    public class FotometresController : Controller
    {
        // GET: Fotometres
        public ActionResult Index()
        {
            return PartialView();
        }
    }
}