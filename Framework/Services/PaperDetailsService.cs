using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Framework.Entities;
using Framework.Repositories;

namespace Framework.Services
{
    public class PaperDetailsService : IPaperDetailsService
    {
        private IFrameworkUnitOfWork _frameworkUnitOfWork;
        public PaperDetailsService(IFrameworkUnitOfWork frameworkUnitOfWork)
        {
            _frameworkUnitOfWork = frameworkUnitOfWork;
        }
        public void CreatePaperDetails(PaperDetails paperDetails)
        {
            _frameworkUnitOfWork.PaperDetailsRepository.Add(paperDetails);
            _frameworkUnitOfWork.Save();
        }

        public PaperDetails DeletePaperDetails(int Id)
        {
            var PaperDetails = _frameworkUnitOfWork.PaperDetailsRepository.GetById(Id);
            _frameworkUnitOfWork.PaperDetailsRepository.Remove(Id);
            _frameworkUnitOfWork.Save();
            return PaperDetails;
        }

        public void Dispose()
        {
            _frameworkUnitOfWork.Dispose();
        }

        public void EditPaperDetails(PaperDetails paperDetails)
        {
            var existingPaperDetails = _frameworkUnitOfWork.PaperDetailsRepository.GetById(paperDetails.Id);
            existingPaperDetails.PaperTilte = paperDetails.PaperTilte;
            existingPaperDetails.AuthorName = paperDetails.AuthorName;
            
            existingPaperDetails.Volume = paperDetails.Volume;
            existingPaperDetails.Page = paperDetails.Page;
            //existingPaperDetails.ResearchSeminar = paperDetails.ResearchSeminar;
            //existingPaperDetails.ResearchCollaboration = paperDetails.ResearchCollaboration;
            existingPaperDetails.ConferenceLocation = paperDetails.ConferenceLocation;
            _frameworkUnitOfWork.Save();
        }

        public (IList<PaperDetails> paperDetails, int total, int totalDisplay) GetPaperDetails(int pageindex, int Pagesize, string searchText, string sortText)
        {
            var result = _frameworkUnitOfWork.PaperDetailsRepository.GetAll().ToList();
            return (result, 0, 0);
        }

        public PaperDetails GetPaperDetails(int Id)
        {
            return _frameworkUnitOfWork.PaperDetailsRepository.GetById(Id);
        }

        public IList<PaperCategory> GetpaperCategories()
        {
            return _frameworkUnitOfWork.PaperCategoryRepository.GetAll();
        }

        //public IList<PaperCategory> paperCategories(int Id)
        //{
        //    //return _frameworkUnitOfWork.PaperCategoryRepository.Get(x => x.PaperDetails.)
        //}
    }
}
