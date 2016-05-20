using OdeToFood2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood2.Controllers
{
    public class HomeController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Index()
        {
            var model = _db.Restaurants.ToList();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var model = new Greeter();
            model.greeting = "Hello World!";
            model.location = "Maryland, USA";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}