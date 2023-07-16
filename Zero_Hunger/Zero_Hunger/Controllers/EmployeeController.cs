using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zero_Hunger.DB;
using Zero_Hunger.Models;

namespace Zero_Hunger.Controllers
{
    public class EmployeeController : Controller
    {
        Zero_HungerEntities db = new Zero_HungerEntities();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(EmployeeDTO em)
        {
            db.Employees.Add(Convert(em));
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ViewEmployee()
        {
            var emp = db.Employees.ToList();
            var emps = Convert(emp);
            return View(emps);
        }
        public ActionResult DeleteEmployee(int id)
        {
            var find = db.Employees.Find(id);
            db.Employees.Remove(find);
            db.SaveChanges();
            return RedirectToAction("ViewEmployee");
        }

        public ActionResult AssignEmployee(EmployeeAssignment ead)
        {
            var employee = db.Employees.Find(ead.EmpID);
            var restaurant = db.Restaurants.Find(ead.RestID);

            if (employee != null && restaurant != null)
            {
                EmployeeAssignment e = new EmployeeAssignment();
                e.EmpID = employee.EmpID;
                e.RestID = restaurant.RestID;
                db.EmployeeAssignments.Add(e);
                db.SaveChanges();
                return RedirectToAction("ViewAssignEmployee");
            }
            else
            {
                return View();
            }  
        }

        public ActionResult ViewAssignEmployee()
        {
            var emp = db.EmployeeAssignments.ToList();
            var emps = Convert(emp);
            return View(emps);
        }

        public ActionResult DeleteAssignEmployee(int id)
        {
            var find = db.EmployeeAssignments.Find(id);
            db.EmployeeAssignments.Remove(find);
            db.SaveChanges();
            return RedirectToAction("ViewAssignEmployee");
        }
        


        //CONV EMPLOYEE
        EmployeeDTO Convert(Employee p)
        {
            var pr = new EmployeeDTO()
            {
                EmpID = p.EmpID,
                EmpName = p.EmpName,
                Contact = p.Contact
            };
            return pr;
        }

        Employee Convert(EmployeeDTO p)
        {
            var pr = new Employee()
            {
                EmpID = p.EmpID,
                EmpName = p.EmpName,
                Contact = p.Contact
            };
            return pr;
        }

        List<EmployeeDTO> Convert(List<Employee> ps)
        {
            var products = new List<EmployeeDTO>();
            foreach (var item in ps)
            {
                products.Add(Convert(item));
            }
            return products;
        }


        //CONV EMPASSIGNMENT
        EmpAssignmentDTO Convert(EmployeeAssignment p)
        {
            var pr = new EmpAssignmentDTO()
            {
                AssID = p.AssID,
                EmpID = p.EmpID,
                RestID = p.RestID
            };
            return pr;
        }

        EmployeeAssignment Convert(EmpAssignmentDTO p)
        {
            var pr = new EmployeeAssignment()
            {
                AssID = p.AssID,
                EmpID = p.EmpID,
                RestID = p.RestID
            };
            return pr;
        }

        List<EmpAssignmentDTO> Convert(List<EmployeeAssignment> ps)
        {
            var products = new List<EmpAssignmentDTO>();
            foreach (var item in ps)
            {
                products.Add(Convert(item));
            }
            return products;
        }        
    }
}