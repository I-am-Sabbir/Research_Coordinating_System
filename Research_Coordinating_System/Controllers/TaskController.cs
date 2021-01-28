using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Research_Coordinating_System.Models;
using Research_Coordinating_System.Models.Task;

namespace Research_Coordinating_System.Controllers
{
    [Authorize(Roles = "Faculty")]
    public class TaskController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<FacultyTaskModel> _logger;
        public TaskController(IConfiguration configuration, ILogger<FacultyTaskModel> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var model = Startup.AutofacContainer.Resolve<FacultyTaskModel>();
            return View(model);
        }

        public IActionResult GetTasks()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<FacultyTaskModel>();
            var currentUser = User.FindFirstValue(ClaimTypes.Name);
            var data = model.GetTask(tableModel, currentUser);

            return Json(data);
        }
    }
}
