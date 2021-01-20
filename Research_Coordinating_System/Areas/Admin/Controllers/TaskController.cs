using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Research_Coordinating_System.Areas.Admin.Models.TaskModel;
using Research_Coordinating_System.Models;

namespace Research_Coordinating_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TaskController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<TaskModel> _logger;

        public TaskController(IConfiguration configuration, ILogger<TaskModel> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var model = Startup.AutofacContainer.Resolve<TaskModel>();
            return View(model);
        }

        public IActionResult GetTasks()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<TaskModel>();
            var data = model.GetTask(tableModel);
            return Json(data);
        }

        public IActionResult AssignTask()
        {
            var model = new AssignTaskModel();
            return View(model);
        }
    }
}
