using Autofac;
using Framework.Services;
using Membership.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Areas.Admin.Models.TaskModel
{
    public class TaskBaseModel : AdminBaseModel, IDisposable
    {
        protected ITaskService _taskService;
        protected IUserService _userService;
        public TaskBaseModel(ITaskService taskService, IUserService userService)
        {
            _taskService = taskService;
            _userService = userService;
        }

        public TaskBaseModel()
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
