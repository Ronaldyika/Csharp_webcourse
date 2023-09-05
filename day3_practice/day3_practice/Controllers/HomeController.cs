using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using day3_practice.Models;

namespace day3_practice.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            List<Employee> _employee = new List<Employee>(){
                new Employee(){
                    EmployeeID = 1,
                    name = "Ronald",
                    address = "Bambili",
                    tell = 237651211000,
                    married = true

                },
                                new Employee(){
                    EmployeeID = 1,
                    name = "Ronald",
                    address = "Bambili",
                    tell = 237651211000,
                    married = true

                },
                                new Employee(){
                    EmployeeID = 2,
                    name = "Robin",
                    address = "Bambili",
                    tell = 237651211000,
                    married = true

                },
                                new Employee(){
                    EmployeeID = 3,
                    name = "Yika",
                    address = "Bambili",
                    tell = 237651211000,
                    married = false

                }

            };
            ViewBag.Employee = _employee;
            return View();
        }
	}
}