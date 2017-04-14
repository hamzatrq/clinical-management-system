using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using cms.Models;
using cms.Models.AccountViewModels;
using cms.Services;

namespace cms.Controllers
{
    [Authorize]
    public class PortalController : Controller
    {
        public PortalController()
        {}
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
