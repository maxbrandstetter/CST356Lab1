using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            // Old code, before model
            ViewBag.Name = "Max Brandstetter";
            ViewBag.DOB = "November 19, 1995";
            ViewBag.Address = "1234 Something Street, Oregon City, OR";

            // Same as above if but using the Person model, not usable without database?
            Person person = new Models.Person();
            person.Name = "Max Brandstetter";
            person.DOB = "November 19, 1995";
            person.Address = "1234 Something Street, Oregon City, OR";

            return View();
        }

    }
}