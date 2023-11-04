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
            ViewBag.Title = "IMAGE UPLOAD";
            ViewBag.Title = "HOME api 1 GIT UI ";
            ViewBag.Title = "HOME PAGE 1 GIT UI ";
            ViewBag.Title = "Home Page 1 GIt UI ";
            ViewBag.Title = "Home Page 1 GIt UI " ;
            ViewBag.Title = "Home Page 2 GIt UI ";
            ViewBag.Title = "Home Page 1 GIt UI ";
            ViewBag.Title = "Home Page 2 GIt UI ";

            string feauture="New feautr1";

            string secondfeauture="seond";


            return View();
        }
    }
}
