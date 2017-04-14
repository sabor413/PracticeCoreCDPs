using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticeCoreCDPs.Areas.Singleton.Core;

namespace PracticeCoreCDPs.Areas.Singleton.Controllers
{
    [Area("Singleton")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            WebsiteMetadata metadata = WebsiteMetadata.GetInstance();

            return View("Index", metadata);
        }
    }
}
