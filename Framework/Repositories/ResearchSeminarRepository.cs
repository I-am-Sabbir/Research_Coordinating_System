using Data;
using Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Repositories
{
    public class ResearchSeminarRepository : Repository<ResearchSeminar, int, FrameworkContext>, IResearchSeminarRepository
    {
        public ResearchSeminarRepository(FrameworkContext frameworkContext) : base(frameworkContext)
        {

        }
    }
}
