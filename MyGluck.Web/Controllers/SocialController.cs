using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyGluck.Web.Controllers
{
    public class SocialController : Controller
    {
        //
        // GET: /Social/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public RedirectResult Logout()
        {
            return Redirect("~");
        }
	}
}