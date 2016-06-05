using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoWiki.Controllers
{
   
        public class NewsController : Controller
        {
            // GET: News
            public ActionResult Index()
            {
                return View();
                //  return "here is the news";
            }

            public ActionResult News(string name, int numTimes = 0)
            {
                ViewBag.name = name;
                ViewBag.numTimes = numTimes;
                return View();
                // return "Audi";
            }
        }
    }
