using Framework.Entities;
using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Repositories
{
    public class TaskRepository : Repository<Task, int, FrameworkContext>, ITaskRepository
    {
        public TaskRepository(FrameworkContext frameworkContext) : base(frameworkContext)
        {

        }
    }
}
