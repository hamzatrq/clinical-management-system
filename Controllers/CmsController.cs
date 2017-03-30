using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cms.Controllers
{
    public class CmsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Doctors()
        {
            return View();
        }

        public IActionResult Faqs()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
