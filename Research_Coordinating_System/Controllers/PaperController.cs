using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Autofac;
using Research_Coordinating_System.Models.Paper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Research_Coordinating_System.Models;

namespace Research_Coordinating_System.Controllers
{
    [Authorize]
    public class PaperController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<PaperModel> _logger;

        public PaperController(IConfiguration configuration, ILogger<PaperModel> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var model = Startup.AutofacContainer.Resolve<PaperModel>();
            return View(model);
        }

        public IActionResult GetPapers()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<PaperModel>();
            var data = model.GetPaperDetails(tableModel);
            return Json(data);
        }
    }
}
