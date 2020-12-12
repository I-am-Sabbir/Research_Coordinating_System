using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Framework.Entities;

namespace Framework.Repositories
{
    public class ResearchCollaborationRepository : Repository<ResearchCollaboration, int, FrameworkContext>, IResearchCollaborationRepository
    {
        public ResearchCollaborationRepository(FrameworkContext frameworkContext) : base(frameworkContext)
        {

        }
    }
}
