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

        public PartialViewResult _MenuLateral()
        {
            return PartialView();
        }

        [HttpPost]
        public RedirectResult Logout()
        {
            return Redirect("~");
        }
	}
}