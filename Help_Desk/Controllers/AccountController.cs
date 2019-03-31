using Help_Desk.Component;
using Help_Desk.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Help_Desk.Controllers
{
    public class AccountController : Controller
    {
        AccountComponent objComponent = new AccountComponent();
        public ActionResult UserRegistration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserRegistration(UserDetails userDetails)
        {
            bool a = objComponent.SaveUserDetails(userDetails);
            return View();
        }
    }
}