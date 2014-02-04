using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WhatsNew_Mobile.Controllers
{
    public class MobilePhotoController : Controller
    {
        //
        // GET: /MobilePhoto/

        public ActionResult Gallery()
        {
            return this.File("~/App_Data/Photos.json", "application/json");
        }

    }
}
