using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using BLL;
namespace AppUI.Controllers
{
    public class CommonController : Controller
    {
        // GET: Common
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AboutUs()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ValidateAdmin(UserInfo userInfo)
        {
            UserInfoBLL userInfoBLL = new UserInfoBLL();
            var result = userInfoBLL.ValidateUser(userInfo);
            if (result)
            {
                Session["email"] = userInfo.Email;
                return RedirectToRoute(
                    new
                    {
                        controller="Admin",
                        action= "AddEmployee"
                    }
                    );
            }
            else
            {
                ViewBag.error = "Incorrect Email Id or Password";
                return View("AdminLogin");
            }
        }
        public ActionResult EmployeeLogin()
        {
          
            return View();
        }
    }
}