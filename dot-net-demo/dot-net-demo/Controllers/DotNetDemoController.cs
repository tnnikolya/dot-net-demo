using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dot_net_demo.Controllers
{
    public class DotNetDemoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}