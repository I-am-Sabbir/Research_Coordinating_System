using Framework.Entities;
using Framework.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.Services
{
    public class PaperCategoryService : IPaperCategoryService
    {
        private IFrameworkUnitOfWork _frameworkUnitOfWork;

        public PaperCategoryService(IFrameworkUnitOfWork frameworkUnitOfWork)
        {
            _frameworkUnitOfWork = frameworkUnitOfWork;
        }

        public void CreateCategory(PaperCategory paperCategory)
        {
            _frameworkUnitOfWork.PaperCategoryRepository.Add(paperCategory);
            _frameworkUnitOfWork.Save();
        }

       
        public PaperCategory DeleteCategory(int Id)
        {
            var PaperCategory = _frameworkUnitOfWork.PaperCategoryRepository.GetById(Id);
            _frameworkUnitOfWork.PaperCategoryRepository.Remove(Id);
            _frameworkUnitOfWork.Save();
            return PaperCategory;
        }

        public void Dispose()
        {
            _frameworkUnitOfWork.Dispose();
        }

        public void EditPaperCategory(PaperCategory paperCategory)
        {
            var existingCategory = _frameworkUnitOfWork.PaperCategoryRepository.GetById(paperCategory.Id);
            existingCategory.CategoryName = paperCategory.CategoryName;
            _frameworkUnitOfWork.Save();
        }

        

        public PaperCategory GetPaperCategory(int Id)
        {
            return _frameworkUnitOfWork.PaperCategoryRepository.GetById(Id);
        }

        public (IList<PaperCategory> paperCategories, int total, int totalDisplay) GetPaperCategories(int pageindex, int Pagesize, string searchText, string sortText)
        {
            var result = _frameworkUnitOfWork.PaperCategoryRepository.GetAll().ToList();
            return (result, 0, 0);
        }

        //public IList<PaperDetails> PaperDetails(int Id)
        //{
        //    //return _frameworkUnitOfWork.PaperDetailsRepository.Get
        //}
    }
}
