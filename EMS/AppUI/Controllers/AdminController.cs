using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppUI.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpGet]
        public ActionResult EmployeeList()
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
                new {
                    controller="Common",
                    action="Index"
                    }
                );
        }
    }
}