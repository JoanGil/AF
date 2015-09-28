using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AF.Controllers
{
    public class ContacteController : Controller
    {
        // GET: Contacte
        public ActionResult Index()
        {
            return PartialView();
        }
    }
}