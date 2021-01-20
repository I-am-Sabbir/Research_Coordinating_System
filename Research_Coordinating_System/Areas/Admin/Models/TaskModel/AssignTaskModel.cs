using Autofac;
using Framework.Services;
using Framework.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Membership.Services;

namespace Research_Coordinating_System.Areas.Admin.Models.TaskModel
{
    public class AssignTaskModel : TaskBaseModel
    {
        [Required]
        [StringLength(100, MinimumLength = 5)]
        [Display(Name = "Task")]
        public string TaskName { get; set; }

        [Required]
        [Display(Name = "DeadLine")]
        public DateTime DeadLine { get; set; }
        public string File { get; set; }
        public string TaskAuthor { get; set; }

        [Required]
        [Display(Name = "Assigning To")]
        public string AssignesTo { get; set; }

        public AssignTaskModel(ITaskService taskService, IUserService userService) : base(taskService, userService)
        {

        }

        public AssignTaskModel() : base()
        {

        }

        public void Add()
        {
            var hostingEnvironment = Startup.AutofacContainer.Resolve<IWebHostEnvironment>();

            var Task = new Task()
            {
                TaskName = this.TaskName,
                DeadLine = this.DeadLine,
                TaskAuthor = this.TaskAuthor,
                AssignesTo = this.AssignesTo
            };
            _taskService.CreateTask(Task);
        }
    }
}
