using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppUI.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [HttpGet]
        public ActionResult LeaveApplication()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ViewSalarySheet()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UpdateProfile()
        {
            return View();
        }
        [HttpGet]
        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToRoute(
                new
                {
                    controller = "Common",
                    action = "Index"
                }
                );
        }
    }
}