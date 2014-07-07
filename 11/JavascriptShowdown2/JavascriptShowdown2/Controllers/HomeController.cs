using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JavascriptShowdown2.Models;

namespace JavascriptShowdown2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index(HomeModel model)
        {
            model.ListaDanych = new Dictionary<int, string>()
            {
                { 1, "mq" },
                { 2, "Mg8" },
            };

            return View(model);
        }

    }
}
