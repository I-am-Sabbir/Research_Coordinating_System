using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Framework.Entities;

namespace Framework.Repositories
{
    public interface IResearchSeminarRepository : IRepository<ResearchSeminar, int, FrameworkContext>
    {
    }
}
