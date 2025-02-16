using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "AA";
            ViewBag.Title = "BB" ;
            ViewBag.Title = "Home Page 1 GIt UI " ;
            string feauture="New feautr1";
ViewBag.Title = "latest";

            ViewBag.Title = "Home Page 2 GIt UI push ";
            string secondfeauture="seond";


            return View();
        }
    }
}
