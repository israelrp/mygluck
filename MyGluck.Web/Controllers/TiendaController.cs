using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyGluck.Web.Controllers
{
    public class TiendaController : Controller
    {
        //
        // GET: /Tienda/
        public PartialViewResult _ProductosMasVendidos()
        {
            return PartialView();
        }
	}
}