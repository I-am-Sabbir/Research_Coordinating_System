using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Framework;
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
        private readonly FrameworkContext _frameworkContext;

        public ReportController(IConfiguration configuration, ILogger<ReportModel> logger, FrameworkContext frameworkContext)
        {
            _configuration = configuration;
            _logger = logger;
            _frameworkContext = frameworkContext;
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
            var scopusJournal = _frameworkContext.PaperDetails.Where(sj => sj.PaperCategoryId == 1).ToList();
            var scopusConference = _frameworkContext.PaperDetails.Where(sc => sc.PaperCategoryId == 2).ToList();
            var scopusBook = _frameworkContext.PaperDetails.Where(sb => sb.PaperCategoryId == 3).ToList();
            var nonScopusJournal = _frameworkContext.PaperDetails.Where(nsj => nsj.PaperCategoryId == 4).ToList();
            var nonScopusConference = _frameworkContext.PaperDetails.Where(nsc => nsc.PaperCategoryId == 5).ToList();
            var nonScopusBook = _frameworkContext.PaperDetails.Where(nsb => nsb.PaperCategoryId == 6).ToList();

            //Count
            ViewBag.ScopusCount = scopusJournal.Count() + scopusConference.Count() + scopusBook.Count();
            ViewBag.NonScopusCount = nonScopusJournal.Count() + nonScopusConference.Count() + nonScopusBook.Count();
          
            ViewBag.ScopusJournal = scopusJournal;
            ViewBag.ScopusConference = scopusConference;
            ViewBag.ScopusBook = scopusBook;


            ViewBag.NonScopusJournal = nonScopusJournal;

            return View(model);
        }
    }
}
