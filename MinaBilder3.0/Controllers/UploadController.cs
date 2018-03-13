using MinaBilder3._0;
using MinaBilder3._0.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;


//http://www.aurigma.com/upload-suite/developers/aspnet-mvc/how-to-upload-files-in-aspnet-mvc
//http://cpratt.co/file-uploads-in-asp-net-mvc-with-view-models/
namespace Mina_Bilder.Controllers
{
    [Authorize]
    public class UploadController : Controller
    {
        // GET: Upload


        public ActionResult Index()
        {
            ViewBag.IsUserLoggedIn = false;
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Upload(UploadModel model, HttpPostedFileBase file)
        {
          
                if (file != null)
                {
                    using (ImagesModel db = new ImagesModel())
                    {

                    string path = Path.Combine(Server.MapPath("~/Bilder"),
                                       Path.GetFileName(file.FileName));
                    file.SaveAs(path);


                    Images nModel = new Images();
                    nModel.Titel = model.Titel;
                    nModel.Kommentar = model.Kommentar;
                    nModel.Path = file.FileName;

                    db.Images.Add(nModel);
                    db.SaveChanges();

                    }
                }
            

            return RedirectToAction("Index", "Images");
        }
    }
}