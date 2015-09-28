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
        public ActionResult Index(String Camera)
        {
            //Call DAO and get from a suposed DB, return view with object and information
            return View();
        }
    }
}