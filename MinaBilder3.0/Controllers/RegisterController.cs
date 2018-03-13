using MinaBilder3._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mina_Bilder.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Users newUser)
        {
            if (ModelState.IsValid)
            {
                //Sparar ett object av en ny användare
                using (ImagesModel db = new ImagesModel())
                {
                    db.Users.Add(newUser);
                    db.SaveChanges();
                    ModelState.Clear();
                    newUser = null;
                    ViewBag.SuccessResult = true;
                }
            }
            return View();
        }
    }
}