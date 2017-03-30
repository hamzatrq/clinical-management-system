using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace portal.Controllers
{
    public class portalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Appointments()
        {
            return View();
        }
        public IActionResult Patients()
        {
            return View();
        }
        public IActionResult Settings()
        {
            return View();
        }
    }
}
