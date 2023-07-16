using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zero_Hunger.DB;
using Zero_Hunger.Models;

namespace Zero_Hunger.Controllers
{
    public class RequestController : Controller
    {
        Zero_HungerEntities db = new Zero_HungerEntities();
        // GET: Request
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddRequest(Request em)
        {
            var AssignID = db.EmployeeAssignments.Find(em.AssID);

            if (AssignID != null)
            {
                Request e = new Request();
                e.AssID = AssignID.AssID;
                e.Status = em.Status;
                db.Requests.Add(e);
                db.SaveChanges();
                return RedirectToAction("ViewRequest");
            }
            else
            {
                return View();
            }
        }

        public ActionResult ViewRequest()
        {
            var emp = db.Requests.ToList();
            var emps = Convert(emp);
            return View(emps);
        }

        public ActionResult DeleteRequest(int id)
        {
            var find = db.Requests.Find(id);
            db.Requests.Remove(find);
            db.SaveChanges();
            return RedirectToAction("ViewRequest");
        }


        //CONV REQUEST

        RequestDTO Convert(Request p)
        {
            var pr = new RequestDTO()
            {
                ReqID = p.ReqID,
                AssID = p.AssID,
                Status = p.Status
            };
            return pr;
        }

        Request Convert(RequestDTO p)
        {
            var pr = new Request()
            {
                ReqID = p.ReqID,
                AssID = p.AssID,
                Status = p.Status
            };
            return pr;
        }

        List<RequestDTO> Convert(List<Request> ps)
        {
            var products = new List<RequestDTO>();
            foreach (var item in ps)
            {
                products.Add(Convert(item));
            }
            return products;
        }

    }
}