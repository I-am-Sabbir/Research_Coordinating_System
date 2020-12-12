using Data;
using Framework.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework
{
    public interface IFrameworkUnitOfWork : IUnitOfWork
    {
        IPaperCategoryRepository PaperCategoryRepository { get; set; }
        IPaperDetailsRepository PaperDetailsRepository { get; set; }
        IResearchCollaborationRepository ResearchCollaborationRepository { get; set; }
        IResearchSeminarRepository ResearchSeminarRepository { get; set; }
        ITaskRepository TaskRepository { get; set; }
    }
}
