using System;
using System.Collections.Generic;
using System.Text;
using Framework.Entities;
using Membership.Entities;

namespace Framework.Services
{
    public interface ITaskService : IDisposable
    {
        (IList<Task> tasks, int total, int totalDisplay) GetTasks(int pageindex,
                                                                              int Pagesize,
                                                                              string searchText,
                                                                              string sortText);
        void CreateTask(Task task);
        void EditTask(Task task);
        Task GetTask(int Id);
        Task DeleteTask(int Id);
        IList<ApplicationUser> GetUser();

    }
}
