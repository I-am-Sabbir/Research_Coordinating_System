using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Models
{
    public class PaperCategoryModel
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name ="Category")]
        public string CategoryName { get; set; }

        public ICollection<PaperDetailsModel> PaperDetails { get; set; }
    }
}
