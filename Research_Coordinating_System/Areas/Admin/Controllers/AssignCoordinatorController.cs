using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Autofac;
using Membership;
using Research_Coordinating_System.Areas.Admin.Models;
using Research_Coordinating_System.Areas.Admin.Models.AssignCoordinator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Research_Coordinating_System.Models;

namespace Research_Coordinating_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AssignCoordinatorController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<AssignModel> _logger;

        public AssignCoordinatorController(IConfiguration configuration, ILogger<AssignModel> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var model = Startup.AutofacContainer.Resolve<AssignModel>();
            return View(model);
        }

        public IActionResult GetCategory()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<AssignModel>();
            var data = model.GetUsers(tableModel);
            return Json(data);
        }
    }
}
