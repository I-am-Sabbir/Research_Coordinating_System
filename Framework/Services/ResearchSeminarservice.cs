using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Framework.Entities;
using Framework.Repositories;

namespace Framework.Services
{
    public class ResearchSeminarservice : IResearchSeminarservice
    {
        private IFrameworkUnitOfWork _frameworkUnitOfWork;

        public ResearchSeminarservice(IFrameworkUnitOfWork frameworkUnitOfWork)
        {
            _frameworkUnitOfWork = frameworkUnitOfWork;
        }

        public void CreateResearchseminar(ResearchSeminar researchSeminar)
        {
            _frameworkUnitOfWork.ResearchSeminarRepository.Add(researchSeminar);
            _frameworkUnitOfWork.Save();
        }

        public void EditResearchseminar(ResearchSeminar researchSeminar)
        {
            var existingSeminar = _frameworkUnitOfWork.ResearchSeminarRepository.GetById(researchSeminar.Id);
            existingSeminar.Title = researchSeminar.Title;
            existingSeminar.ResourcePerson = researchSeminar.ResourcePerson;
            existingSeminar.Date = researchSeminar.Date;
            existingSeminar.Vanue = researchSeminar.Vanue;
            existingSeminar.NumberOfParticipants = researchSeminar.NumberOfParticipants;
            _frameworkUnitOfWork.Save();
        }

        public ResearchSeminar GetResearchseminar(int Id)
        {
            return _frameworkUnitOfWork.ResearchSeminarRepository.GetById(Id);
        }

        public ResearchSeminar DeleteResearchSeminar(int Id)
        {
            var ResearchSeminar = _frameworkUnitOfWork.ResearchSeminarRepository.GetById(Id);
            _frameworkUnitOfWork.ResearchSeminarRepository.Remove(Id);
            _frameworkUnitOfWork.Save();
            return ResearchSeminar;
        }

        public void Dispose()
        {
            _frameworkUnitOfWork.Dispose();
        }

        public (IList<ResearchSeminar> researchSeminars, int total, int totalDisplay) GetResearchSeminars(int pageindex, int Pagesize, string searchText, string sortText)
        {
            var result = _frameworkUnitOfWork.ResearchSeminarRepository.GetAll().ToList();
            return (result, 0, 0);
        }
    }
}
