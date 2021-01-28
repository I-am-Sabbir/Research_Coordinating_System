using Framework.Services;
using Membership.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Models.Task
{
    public class FacultyTaskModel : FacultyTaskBaseModel
    {
        public FacultyTaskModel(ITaskService taskService, IUserService userService) : base(taskService, userService) { }
        public FacultyTaskModel() : base() { }

        internal object GetTask(DataTablesAjaxRequestModel datatables, string currentuser)
        {
            var data = _taskService.GetTasks(datatables.PageIndex,
                                             datatables.PageSize,
                                             datatables.SearchText,
                                             datatables.GetSortText(new string[] { "TaskName", "AssignesTo", "DeadLine" }));
            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.tasks
                        where(record.AssignesTo == currentuser)
                        select new string[]
                        {
                            record.TaskName,
                            record.AssignesTo,
                            record.DeadLine.ToString(),
                            record.Id.ToString()
                        }
                        ).ToArray()
            };
        }

        internal string Delete(int Id)
        {
            var deleteTask = _taskService.DeleteTask(Id);
            return deleteTask.TaskName;
        }
    }
}
