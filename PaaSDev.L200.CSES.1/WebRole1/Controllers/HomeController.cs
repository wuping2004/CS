using Lab.Utility.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebRole1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = StringCipher.Encrypt("passworld", "abc");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = StringCipher.Encrypt("passworld", "abc");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}