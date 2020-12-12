using System;
using System.Collections.Generic;
using System.Text;
using Framework.Entities;
using Data;

namespace Framework.Repositories
{
    public interface IPaperDetailsRepository : IRepository<PaperDetails, int, FrameworkContext>
    {
    }
}
