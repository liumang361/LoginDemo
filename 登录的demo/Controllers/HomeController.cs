using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Index(Person p)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        ModelState.AddModelError("", "成功");
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("", "失败");
        //    }
        //    return View();
        //}

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            if (Request.IsAjaxRequest())
            {
                return JavaScript("alert('好');");
            }

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}