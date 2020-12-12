using Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Services
{
    public interface IPaperCategoryService : IDisposable
    {
        (IList<PaperCategory> paperCategories, int total, int totalDisplay) GetPaperCategories(int pageindex,
                                                                              int Pagesize,
                                                                              string searchText,
                                                                              string sortText);
        void CreateCategory(PaperCategory paperCategory);
        void EditPaperCategory(PaperCategory paperCategory);
        //IList<PaperDetails> PaperDetails(int Id);
        PaperCategory GetPaperCategory(int Id);
        PaperCategory DeleteCategory(int Id);
    }
}
