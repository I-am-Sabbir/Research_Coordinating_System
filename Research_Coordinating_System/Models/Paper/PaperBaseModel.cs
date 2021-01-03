using Autofac;
using Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Models.Paper
{
    public class PaperBaseModel : FacultyBaseModel, IDisposable
    {
        protected IPaperDetailsService _paperDetailsService;
        public PaperBaseModel(IPaperDetailsService paperDetailsService)
        {
            _paperDetailsService = paperDetailsService;
        }

        public PaperBaseModel()
        {
            _paperDetailsService = Startup.AutofacContainer.Resolve<IPaperDetailsService>();
        }

        public void Dispose()
        {
            _paperDetailsService.Dispose();
        }
    }
}
