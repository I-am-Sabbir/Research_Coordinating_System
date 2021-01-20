using Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Models.Task
{
    public class FacultyTaskModel : FacultyTaskBaseModel
    {
        public FacultyTaskModel(ITaskService taskService) : base(taskService) { }
        public FacultyTaskModel() : base() { }

        internal object GetTask(DataTablesAjaxRequestModel datatables)
        {
            var data = _taskService.GetTasks(datatables.PageIndex,
                                             datatables.PageSize,
                                             datatables.SearchText,
                                             datatables.GetSortText(new string[] { "Id", "Title" }));
            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.tasks
                        select new string[]
                        {
                            record.TaskName,
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
