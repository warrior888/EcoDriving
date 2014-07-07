using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JavascriptShowdown.Models;

namespace JavascriptShowdown.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index(HomeModel model)
        {

            model.Id = 2;

            return View(model);
        }

    }
}
