using StudentFeedback.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentFeedback.Controllers
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

        public ActionResult Welcome()
        {
            var gender = from Gender e in Enum.GetValues(typeof(Gender))
                         select new { name = e.ToString() };
            

            ViewBag.Gender = new SelectList(gender, "name");
            return View(new Student());
        }

        public ActionResult Feedack()
        {

            return View();
        }

        public ActionResult FeedackShow(Student student)
        {
            if(ModelState.IsValid)
            {
                ViewBag.St = student;
                return View();
            }
            return View("Feedack");
            ViewBag.St=student;
            return View();
        }
    }
}