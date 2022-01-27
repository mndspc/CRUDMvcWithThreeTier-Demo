using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using BLL;
namespace AppUI.Controllers
{
    public class AdminController : Controller
    {
        EmpProfileBLL empProfileBLL = new EmpProfileBLL();
        // GET: Admin
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveEmployee(EmpProfile empProfile)
        {
            var result = empProfileBLL.SaveEmployee(empProfile);
            if (result)
            {
                return RedirectToAction("EmployeeList");
            }
            else
            {
                return View("AddEmployee");
            }
        }

        [HttpGet]
        public ActionResult EmployeeList()
        {
            var employeeList = empProfileBLL.SelectAllEmployee();
            ViewBag.count = employeeList.Count;
            return View(employeeList);
        }

        public ActionResult DeleteEmployee(int id)
        {
            var emp = empProfileBLL.SelectEmpByCode(id);
           var result= empProfileBLL.DeleteEmployee(emp);
            if (result)
            {
                return RedirectToAction("EmployeeList");
            }
            else
            {
                return RedirectToAction("EmployeeList");
            }
        }

        [HttpGet]
        public ActionResult UpdateEmployee(int id)
        {
            var emp=empProfileBLL.SelectEmpByCode(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult UpdateProfile(EmpProfile empProfile)
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