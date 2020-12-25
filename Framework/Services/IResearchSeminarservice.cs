using System;
using System.Collections.Generic;
using System.Text;
using Framework.Entities;

namespace Framework.Services
{
    public interface IResearchSeminarService : IDisposable
    {
        (IList<ResearchSeminar> researchSeminars, int total, int totalDisplay) GetResearchSeminars(int pageindex,
                                                                              int Pagesize,
                                                                              string searchText,
                                                                              string sortText);
        void CreateResearchseminar(ResearchSeminar researchSeminar);
        void EditResearchseminar(ResearchSeminar researchSeminar);
        ResearchSeminar GetResearchseminar(int Id);
        ResearchSeminar DeleteResearchSeminar(int Id);
    }
}
