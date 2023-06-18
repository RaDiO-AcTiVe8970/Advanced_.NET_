using lab_task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_task.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult test()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Resgistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Resgistration(Register reg)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("test");
            }
            return View(reg);
        }
    }
}