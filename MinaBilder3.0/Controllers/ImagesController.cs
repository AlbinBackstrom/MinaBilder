using MinaBilder3._0;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mina_Bilder.Controllers
{
    public class ImagesController : Controller
    {
        // GET: Images
        public ActionResult Index()
        {
            //skapar en lista med bildernas sökväg, titel och kommentarer för att sedan loopas genom
            //i view och "stoppas" in i ett plugin som heter Lightbox som är från http://ashleydw.github.io/lightbox/
            List<Images> imageList = new List<Images>();
            using (ImagesModel db = new ImagesModel())
            {
                imageList = (from i in db.Images
                             select i).ToList(); 

            }
            return View(imageList); 
        }
    }
}