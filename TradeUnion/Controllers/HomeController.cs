using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TradeUnion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult HomeIndex()
        {
            return View();
        }
    }
}