using Framework.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Areas.Coordinator.Models
{
    public class ReportModel : ReportBaseModel
    {
        [Required]
        public string Department { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Quarter { get; set; }

        [Required]
        [Display(Name = "Name & Designation of Coordinator")]
        public string NameAndDesignation { get; set; }


        public ReportModel(IPaperDetailsService paperDetailsService, IPaperCategoryService paperCategoryService) : base(paperDetailsService, paperCategoryService)
        {

        }

        public ReportModel() : base() { }




    }
}
