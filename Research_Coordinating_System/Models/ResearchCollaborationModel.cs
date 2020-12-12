using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Models
{
    public class ResearchCollaborationModel
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name ="Partner Name")]
        public string PartnerName { get; set; }
        
        [Display(Name ="Country")]
        public string Country { get; set; }
        
        [Display(Name ="Description")]
        public string Description { get; set; }
        
        [Display(Name ="Date")]
        public DateTime Date { get; set; }

        public PaperDetailsModel PaperDetails { get; set; }
    }
}
