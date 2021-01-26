using Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Areas.Coordinator.Models
{
    public class PaperAndCategoryModel
    {
        public PaperDetails PaperDetails { get; set; }
        public PaperCategory PaperCategories { get; set; }

        public PaperAndCategoryModel()
        {
            PaperDetails = new PaperDetails();
            PaperCategories = new PaperCategory();
        }

       
    }
}
