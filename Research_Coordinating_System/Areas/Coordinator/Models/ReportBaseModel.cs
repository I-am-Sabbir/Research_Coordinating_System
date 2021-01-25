using Autofac;
using Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Areas.Coordinator.Models
{
    public class ReportBaseModel : CoordinatorBaseModel, IDisposable
    {
        public IPaperDetailsService _paperDetailsService;
        public IPaperCategoryService _paperCategoryService;
        public ReportBaseModel(IPaperDetailsService paperDetailsService, IPaperCategoryService paperCategoryService)
        {
            _paperDetailsService = paperDetailsService;
            _paperCategoryService = paperCategoryService;
        }

        public ReportBaseModel()
        {
            _paperDetailsService = Startup.AutofacContainer.Resolve<IPaperDetailsService>();
            _paperCategoryService = Startup.AutofacContainer.Resolve<IPaperCategoryService>();
        }

        public void Dispose()
        {
            _paperDetailsService.Dispose();
            _paperCategoryService.Dispose();
        }
    }
}
