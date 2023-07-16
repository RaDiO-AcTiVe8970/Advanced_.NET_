using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zero_Hunger.DB;
using Zero_Hunger.Models;

namespace Zero_Hunger.Controllers
{
    public class RestaurantController : Controller
    {
        Zero_HungerEntities db = new Zero_HungerEntities();
        // GET: Restaurant
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddCollReq()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCollReq(RestaurantDTO em)
        {
            db.Restaurants.Add(Convert(em));
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ViewCollReq()
        {
            var emp = db.Restaurants.ToList();
            var emps = Convert(emp);
            return View(emps);
        }

        public ActionResult DeleteCollReq(int id)
        {
            var find = db.Restaurants.Find(id);
            db.Restaurants.Remove(find);
            db.SaveChanges();
            return RedirectToAction("ViewCollReq");
        }

        //CONV RESTAURANT
        RestaurantDTO Convert(Restaurant p)
        {
            var pr = new RestaurantDTO()
            {
                FoodType = p.FoodType,
                PreserveTime = p.PreserveTime,
                RestID = p.RestID
            };
            return pr;
        }

        Restaurant Convert(RestaurantDTO p)
        {
            var pr = new Restaurant()
            {
                FoodType = p.FoodType,
                PreserveTime = p.PreserveTime,
                RestID = p.RestID
            };
            return pr;
        }

        List<RestaurantDTO> Convert(List<Restaurant> ps)
        {
            var products = new List<RestaurantDTO>();
            foreach (var item in ps)
            {
                products.Add(Convert(item));
            }
            return products;
        }
    }
}