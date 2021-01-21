using Autofac;
using Membership.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Areas.Admin.Models.AssignCoordinator
{
    public class AssignBaseModel : AdminBaseModel, IDisposable
    {
        protected IUserService _userService;

        public AssignBaseModel(IUserService userService)
        {
            _userService = userService;
        }

        public AssignBaseModel()
        {
            _userService = Startup.AutofacContainer.Resolve<IUserService>();
        }

        public void Dispose()
        {
            _userService.Dispose();
        }
    }
}
