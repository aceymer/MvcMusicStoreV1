using MvcMusicStore.Models;
using MvcMusicStore.Models.FakeDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(int id)
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Details = new FakeDB().GetDetail(id);
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}