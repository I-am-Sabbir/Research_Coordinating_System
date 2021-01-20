using Autofac;
using Framework.Services;
using Research_Coordinating_System.Areas.Admin.Models;
using Research_Coordinating_System.Areas.Coordinator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Models.Task
{
    public class FacultyTaskBaseModel : FacultyBaseModel
    {
        protected ITaskService _taskService;

        public FacultyTaskBaseModel(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public FacultyTaskBaseModel()
        {
            _taskService = Startup.AutofacContainer.Resolve<ITaskService>();
        }

        public void Dispose()
        {
            _taskService.Dispose();
        }
    }
}
