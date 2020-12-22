using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Research_Coordinating_System.Areas.Coordinator.Models;

namespace Research_Coordinating_System.Areas.Coordinator.Controllers
{
    [Area("Coordinator")]
    [Authorize(Roles = "Coordinator")]
    public class CoordinatorDashboardController : Controller
    {
        public IActionResult Index()
        {
            var model = new CoordinatorDashBoardModel();
            return View(model);

        }

        public IActionResult Report()
        {
            var model = new CoordinatorDashBoardModel();
            return View(model);
        }
    }
}
