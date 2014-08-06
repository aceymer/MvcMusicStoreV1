using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public string Index()
        {
            return "Cake";
        }

        public string Browse(string genre)
        {
            return HttpUtility.HtmlEncode("Browse genre: " + genre);
        }

        public string Details(string genre)
        {
            return "Details genre: " + genre;
        }

    }
}