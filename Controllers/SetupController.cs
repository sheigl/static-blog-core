using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace static_blog_core.Controllers
{
    public class SetupController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
