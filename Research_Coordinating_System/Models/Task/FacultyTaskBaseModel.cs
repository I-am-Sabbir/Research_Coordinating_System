using Autofac;
using Framework.Services;
using Membership.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Models.Task
{
    public class FacultyTaskBaseModel : FacultyBaseModel, IDisposable
    {
        protected ITaskService _taskService;
        protected IUserService _userService;

        public FacultyTaskBaseModel(ITaskService taskService, IUserService userService)
        {
            _taskService = taskService;
            _userService = userService;
        }

        public FacultyTaskBaseModel()
        {
            _taskService = Startup.AutofacContainer.Resolve<ITaskService>();
            _userService = Startup.AutofacContainer.Resolve<IUserService>();
        }

        public void Dispose()
        {
            _taskService.Dispose();
            _userService.Dispose();
        }
    }
}
