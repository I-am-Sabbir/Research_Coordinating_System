using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Framework.Entities;
using Framework.Repositories;

namespace Framework.Services
{
    public class TaskService : ITaskService
    {
        private IFrameworkUnitOfWork _frameworkUnitOfWork;

        public TaskService(IFrameworkUnitOfWork frameworkUnitOfWork)
        {
            _frameworkUnitOfWork = frameworkUnitOfWork;
        }

        public void CreateTask(Task task)
        {
            _frameworkUnitOfWork.TaskRepository.Add(task);
            _frameworkUnitOfWork.Save();
        }

        public void EditTask(Task task)
        {
            var existingTask = _frameworkUnitOfWork.TaskRepository.GetById(task.Id);
            existingTask.TaskName = task.TaskName;
            existingTask.DeadLine = task.DeadLine;
            _frameworkUnitOfWork.Save();
        }

        public Task GetTask(int Id)
        {
            return _frameworkUnitOfWork.TaskRepository.GetById(Id);
        }

        public Task DeleteTask(int Id)
        {
            var Task = _frameworkUnitOfWork.TaskRepository.GetById(Id);
            _frameworkUnitOfWork.TaskRepository.Remove(Id);
            _frameworkUnitOfWork.Save();
            return Task;
        }

        public void Dispose()
        {
            _frameworkUnitOfWork.Dispose();
        }

        public (IList<Task> tasks, int total, int totalDisplay) GetTasks(int pageindex, int Pagesize, string searchText, string sortText)
        {
            var result = _frameworkUnitOfWork.TaskRepository.GetAll().ToList();
            return (result, 0, 0);
        }
   
    }
}
