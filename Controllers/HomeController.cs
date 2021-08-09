using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Signin()
        {
            ViewBag.Message = "Your application registraion page.";

            return View();
        }
        public ActionResult Signup()
        {
            ViewBag.Message = "Your application registraion2 page.";
            

            return View();
        }

        public ActionResult Colleges()
        {
            ViewBag.Message = "Your application Colleges page.";

            return View();
        }

        public ActionResult Eng()
        {
            ViewBag.Message = "Your application Eng page.";

            return View();


        }

        public ActionResult profile()
        {
            ViewBag.Message = "Your application profile page.";

            return View();
        }



    }
}