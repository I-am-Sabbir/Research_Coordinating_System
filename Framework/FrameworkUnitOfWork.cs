using Data;
using Framework.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework
{
    public class FrameworkUnitOfWork : UnitOfWork, IFrameworkUnitOfWork
    {
        public IPaperCategoryRepository PaperCategoryRepository { get; set; }
        public IPaperDetailsRepository PaperDetailsRepository { get; set; }
        public IResearchCollaborationRepository ResearchCollaborationRepository { get; set; }
        public IResearchSeminarRepository ResearchSeminarRepository { get; set; }
        public ITaskRepository TaskRepository { get; set; }

        public FrameworkUnitOfWork(FrameworkContext frameworkContext, IPaperCategoryRepository paperCategoryRepository,
                                                                      IPaperDetailsRepository paperDetailsRepository,
                                                                      IResearchCollaborationRepository researchCollaborationRepository,
                                                                      IResearchSeminarRepository researchSeminarRepository,
                                                                      ITaskRepository taskRepository)
            : base(frameworkContext)
        {
            PaperCategoryRepository = paperCategoryRepository;
            PaperDetailsRepository = paperDetailsRepository;
            ResearchCollaborationRepository = researchCollaborationRepository;
            ResearchSeminarRepository = researchSeminarRepository;
            TaskRepository = taskRepository;
        }
    }
}
