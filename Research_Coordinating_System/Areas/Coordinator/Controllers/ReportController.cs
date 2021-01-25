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
    public class ReportController : Controller
    {

        private readonly IConfiguration _configuration;
        private readonly ILogger<ReportModel> _logger;

        public ReportController(IConfiguration configuration, ILogger<ReportModel> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var model = new ReportModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index([Bind(nameof(ReportModel.Department),
                                         nameof(ReportModel.Date),
                                         nameof(ReportModel.Quarter),
                                         nameof(ReportModel.NameAndDesignation))]
                                         ReportModel model)
        {

            return RedirectToAction("Report",model);
        }

        public IActionResult Report(ReportModel model)
        {

            return View(model);
        }
    }
}
