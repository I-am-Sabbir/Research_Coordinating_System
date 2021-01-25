using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Research_Coordinating_System.Areas.Admin.Models;

namespace Research_Coordinating_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminDashboardController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<AdminDashBoardModel> _logger;

        public AdminDashboardController(IConfiguration configuration, ILogger<AdminDashBoardModel> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var model = new AdminDashBoardModel();
            return View(model);

        }
    }
}
