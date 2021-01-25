using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Research_Coordinating_System.Areas.Coordinator.Models;

namespace Research_Coordinating_System.Areas.Coordinator.Controllers
{
    [Area("Coordinator")]
    [Authorize(Roles = "Coordinator")]
    public class CoordinatorDashboardController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<CoordinatorDashBoardModel> _logger;

        public CoordinatorDashboardController(IConfiguration configuration, ILogger<CoordinatorDashBoardModel> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new CoordinatorDashBoardModel();
            return View(model);

        }
    }
}
