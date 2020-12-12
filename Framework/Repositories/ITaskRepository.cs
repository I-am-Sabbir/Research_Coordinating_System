using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Framework.Entities;

namespace Framework.Repositories
{
    public interface ITaskRepository : IRepository<Task, int, FrameworkContext>
    {
    }
}
