using MinaBilder3._0;
using MinaBilder3._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Mina_Bilder.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(Credentials creds)
        {

            if (creds.Username == null || creds.Password == null)
            {
                ModelState.AddModelError("", "Fyll i både användarnamn och lösenord");
                return View();
            }

            bool userChecked = false;
            userChecked = credentialsCheck(creds.Username, creds.Password);

            if (userChecked == true)
            {
                System.Web.Security.FormsAuthentication.RedirectFromLoginPage(creds.Username, false);
            }
            return View();

        }

        private bool credentialsCheck(string Username, string Password)
        {
            using (ImagesModel db = new ImagesModel())
            {

                var credCheck = from c in db.Users
                                where c.Username == Username
                                && c.Password == Password
                                select c;
                if (credCheck.Count() == 1)
                {
                    return true;
                }
                else
                {
                    ViewBag.LoggedInFail = true;
                    return false;
                }
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Start");
        }

    }


}

