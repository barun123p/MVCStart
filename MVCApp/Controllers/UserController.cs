using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult ValidateUser(UserInfo userInfo)
        {
            bool isValidUser = UserData.GetUsers().Any(x => x.UserName == userInfo.UserName && x.Password == userInfo.Password);
            if (isValidUser)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.ErrorMessage = "Access Denied";
            return View("Login");



        }
    }
}