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

               ViewBag.Title = "BB" ;
            ViewBag.Title = "Home Page 1 GIt UI " ;
            string feauture="New feautr1";

            string secondfeauture="seond";


            return View();
        }
    }
}
