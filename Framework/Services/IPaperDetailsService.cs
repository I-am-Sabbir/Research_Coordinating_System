using System;
using System.Collections.Generic;
using System.Text;
using Framework.Entities;

namespace Framework.Services
{
    public interface IPaperDetailsService : IDisposable
    {
        (IList<PaperDetails> paperDetails, int total, int totalDisplay) GetPaperDetails(int pageindex,
                                                                              int Pagesize,
                                                                              string searchText,
                                                                              string sortText);
        void CreatePaperDetails(PaperDetails paperDetails);
        void EditPaperDetails(PaperDetails paperDetails);
        IList<PaperCategory> GetpaperCategories();
        PaperDetails GetPaperDetails(int Id);
        PaperDetails DeletePaperDetails(int Id);
    }
}
