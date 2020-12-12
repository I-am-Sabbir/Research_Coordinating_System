using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Framework.Entities;

namespace Framework.Repositories
{
    public class PaperDetailsRepository : Repository<PaperDetails, int, FrameworkContext>, IPaperDetailsRepository
    {
        public PaperDetailsRepository(FrameworkContext frameworkContext) : base(frameworkContext)
        {

        }
    }
}
