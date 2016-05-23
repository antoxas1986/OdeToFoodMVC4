using OdeToFood2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood2.Controllers
{
    public class ReviewsController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();
        // GET: Reviews
        public ActionResult Index([Bind(Prefix ="id")] int restaurantId)
        {
            var restaurant = _db.Restaurants.Find(restaurantId);
            if(restaurant != null)
            {
                return View(restaurant);
            }  
            return HttpNotFound();
        }
        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }

        [HttpGet]
        public ActionResult Create(int restaurantId)
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(RestaurantReview r)
        {
            if (ModelState.IsValid)
            {
                _db.Reviews.Add(r);
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = r.RestaurantId });
            }
            return View(r);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _db.Reviews.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(RestaurantReview r)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(r).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = r.RestaurantId });
            }
            return View(r);
        }
    }
}
