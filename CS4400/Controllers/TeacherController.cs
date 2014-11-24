using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS4400.Controllers
{
    public class TeacherController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Ok";

            return View();
        }
    }
}
