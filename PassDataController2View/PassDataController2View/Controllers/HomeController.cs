using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PassDataController2View.Models;

namespace PassDataController2View.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            ViewBag.firstname = "Buhnyuy";
            ViewBag.lastname = "Ronald";
            ViewBag.age = 22;
            return View();
        }

        public ActionResult Employee()
        {
            List<Employee> _employee = new List<Employee>(){
                new Employee(){
                    EmployeeID = 1,
                    Name = "Ronald",
                    Position = "Senior Dev",
                    Maried = true,

                },
                new Employee(){
                    EmployeeID = 2,
                    Name = "Rubben",
                    Position = "Technical Adviser",
                    Maried = false,
                },
                new Employee(){
                    EmployeeID = 3,
                    Name = "Juliene",
                    Position = "BioMed Eng",
                    Maried = false,
                },
                new Employee(){
                    EmployeeID = 4,
                    Name = "Robert",
                    Position = "Content Writer",
                    Maried= true,
                },

            };

            @ViewBag.Employee = _employee;
            return View();
        }

	}
}