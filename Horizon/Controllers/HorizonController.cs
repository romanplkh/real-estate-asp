using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Horizon.Controllers
{
    public class HorizonController : Controller
    {
        // GET: Horizon
        public ActionResult Index()
        {
            return View();
        }
    }
}