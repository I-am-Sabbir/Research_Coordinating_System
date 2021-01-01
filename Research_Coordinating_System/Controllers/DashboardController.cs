using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Research_Coordinating_System.Models;

namespace Research_Coordinating_System.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var model = new FacultyDashboardModel();
            return View(model);
        }
    }
}
