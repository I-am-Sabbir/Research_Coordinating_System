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
using Research_Coordinating_System.Areas.Admin.Models.TaskModel;
using Research_Coordinating_System.Models;

namespace Research_Coordinating_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Coordinator")]
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
            var currentUser = User.FindFirstValue(ClaimTypes.Name);
            var data = model.GetTask(tableModel,currentUser);
           
            return Json(data);
        }

        public IActionResult AssignTask()
        {
            var model = new AssignTaskModel();
            ViewBag.TaskAuthor = User.FindFirstValue(ClaimTypes.Name);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AssignTask([Bind(nameof(AssignTaskModel.TaskName),
                                                nameof(AssignTaskModel.DeadLine),
                                                nameof(AssignTaskModel.AssignesTo),
                                                nameof(AssignTaskModel.TaskAuthor))]
                                            AssignTaskModel model)
        {
            var taskAuthor = model.TaskAuthor;
            if (ModelState.IsValid)
            {

                try
                {
                    model.Add();
                    model.Response = new ResponseModel($"Task Assigned To {model.AssignesTo}", ResponseType.Success);

                    //logger code
                    _logger.LogInformation("Task  Assigned");



                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Task Assigned Failed.", ResponseType.Failure);
                    // error logger code
                    _logger.LogError($"Task Assigned 'Failed'. Excption is : {ex.Message}");
                }

            }
            return RedirectToAction("Index");
        }
    }
}
