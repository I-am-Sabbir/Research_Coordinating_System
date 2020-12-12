using Data;
using Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Repositories
{
    public class PaperCategoryRepository : Repository<PaperCategory, int, FrameworkContext>, IPaperCategoryRepository
    {
        public PaperCategoryRepository(FrameworkContext frameworkContext) : base(frameworkContext)
        {

        }
    }
}
