using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Framework.Entities;
using Framework.Repositories;

namespace Framework.Services
{
    public class ResearchCollaborationService : IResearchCollaborationService
    {
        private IFrameworkUnitOfWork _frameworkUnitOfWork;

        public ResearchCollaborationService(IFrameworkUnitOfWork frameworkUnitOfWork)
        {
            _frameworkUnitOfWork = frameworkUnitOfWork;
        }

        public void CreateResearchCollaboration(ResearchCollaboration researchCollaboration)
        {
            _frameworkUnitOfWork.ResearchCollaborationRepository.Add(researchCollaboration);
            _frameworkUnitOfWork.Save();
        }

        public void Dispose()
        {
            _frameworkUnitOfWork.Dispose();
        }

        public void EditResearchCollaboration(ResearchCollaboration researchCollaboration)
        {
            var existingResearchCollaboration = _frameworkUnitOfWork.ResearchCollaborationRepository.GetById(researchCollaboration.Id);
            existingResearchCollaboration.PartnerName = researchCollaboration.PartnerName;
            existingResearchCollaboration.Country = researchCollaboration.Country;
            existingResearchCollaboration.Description = researchCollaboration.Description;
            existingResearchCollaboration.Date = researchCollaboration.Date;

            _frameworkUnitOfWork.Save();
        }

        public ResearchCollaboration GetResearchCollaboration(int Id)
        {
            return _frameworkUnitOfWork.ResearchCollaborationRepository.GetById(Id);
        }

        public ResearchCollaboration DeleteResearchCollaboration(int Id)
        {
            var ResearchCollaboration = _frameworkUnitOfWork.ResearchCollaborationRepository.GetById(Id);
            _frameworkUnitOfWork.ResearchCollaborationRepository.Remove(Id);
            _frameworkUnitOfWork.Save();
            return ResearchCollaboration;
        }

        public (IList<ResearchCollaboration> researchCollaborations, int total, int totalDisplay) GetResearchCollaborations(int pageindex, int Pagesize, string searchText, string sortText)
        {
            var result = _frameworkUnitOfWork.ResearchCollaborationRepository.GetAll().ToList();
            return (result, 0, 0);
        }
    }
}
