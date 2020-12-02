using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreshLunch_Application.Areas.Admin.Controllers
{
    public class FoodController : Controller
    {
        // GET: Admin/Food
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddFood()
        {
            return View();
        }
    }
}