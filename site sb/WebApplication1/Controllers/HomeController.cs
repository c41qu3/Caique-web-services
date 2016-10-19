using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult CasosRecentes()
        {
            return View();
        }

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
        public ActionResult Acougue()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Padaria()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Restaurante()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}