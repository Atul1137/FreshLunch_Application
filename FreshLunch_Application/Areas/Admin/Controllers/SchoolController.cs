using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreshLunch_Application.Areas.Admin.Controllers
{
    public class SchoolController : Controller
    {
        // GET: Admin/School
        public ActionResult Index()
        {
            return View();
        }
    }
}