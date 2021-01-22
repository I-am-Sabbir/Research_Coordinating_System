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

        public IActionResult GetUsers()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<AssignModel>() ;
            var data = model.GetUsers(tableModel);
            return Json(data);
        }


        public IActionResult EditRole(Guid id)
        {
            var model = new EditAssignModel();
            model.Load(id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditRole([Bind(nameof(EditAssignModel.UserId),
                                                nameof(EditAssignModel.Email))]
                                            EditAssignModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Edit();
                    model.Response = new ResponseModel("Role Assigned.", ResponseType.Success);

                    //logger code
                    _logger.LogInformation("Role  Assigned");

                    

                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Category Edit Failued.", ResponseType.Failure);
                    // error logger code
                    _logger.LogError($"Category Edit 'Failed'. Excption is : {ex.Message}");
                }
            }
            return RedirectToAction("Index");
        }
    }
}
