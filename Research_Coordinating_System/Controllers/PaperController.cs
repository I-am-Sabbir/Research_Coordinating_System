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
    [Authorize(Roles = "Faculty")]
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

        public IActionResult SubmitPaper()
        {
            var model = new AddPaper();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitPaper([Bind(nameof(AddPaper.PaperTilte),
                                            nameof(AddPaper.AuthorName),
                                            nameof(AddPaper.PaperCategoryId),
                                            nameof(AddPaper.Volume),
                                            nameof(AddPaper.Page),
                                            nameof(AddPaper.ConferenceLocation),
                                            nameof(AddPaper.Submitdate))]
                                           AddPaper model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add();
                    model.Response = new ResponseModel("Paper Details Added", ResponseType.Success);

                    //logger code
                    _logger.LogInformation("Paper Added Sucessfully");

                    return RedirectToAction("Index");
                }

                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Paper Additon failed.", ResponseType.Failure);
                    _logger.LogError($"Paper Addition 'Failed'. Excption is : {ex.Message}");
                }
            }
            return View(model);
        }



    }
}
