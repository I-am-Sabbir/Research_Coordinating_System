using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Models
{
    public class ResearchSeminarModel
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name ="Seminar Title")]
        public string Title { get; set; }

        [Display(Name ="Resource Person")]
        public string ResourcePerson { get; set; }

        [Display(Name ="Seminar Date")]
        public DateTime Date { get; set; }

        [Display(Name ="Venue")]
        public string Vanue { get; set; }

        [Display(Name ="Number of Participants")]
        public string NumberOfParticipants { get; set; }

        public PaperDetailsModel PaperDetails { get; set; }

    }
}
