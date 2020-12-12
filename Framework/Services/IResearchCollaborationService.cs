using System;
using System.Collections.Generic;
using System.Text;
using Framework.Entities;

namespace Framework.Services
{
    public interface IResearchCollaborationService : IDisposable
    {
        (IList<ResearchCollaboration> researchCollaborations, int total, int totalDisplay) GetResearchCollaborations(int pageindex,
                                                                              int Pagesize,
                                                                              string searchText,
                                                                              string sortText);
        void CreateResearchCollaboration(ResearchCollaboration researchCollaboration);
        void EditResearchCollaboration(ResearchCollaboration researchCollaboration);
        ResearchCollaboration GetResearchCollaboration(int Id);
        ResearchCollaboration DeleteResearchCollaboration(int Id);

    }
}
