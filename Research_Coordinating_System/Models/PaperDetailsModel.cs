using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Models
{
    public class PaperDetailsModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Require Paper Title")]
        [Display(Name ="Papaer Title")]
        //Unique Field
        public string PaperTilte { get; set; }

        [Required(ErrorMessage ="Require Author Name")]
        [Display(Name ="Author")]
        public string AuthorName { get; set; }

        [Required(ErrorMessage ="Require a Category")]
        [Display(Name ="Category")]
        public string Category { get; set; }

        [Display(Name ="Volume")]
        public string Volume { get; set; }

        [Display(Name ="Page")]
        public string Page { get; set; }

        [Display(Name ="Location")]
        public string ConferenceLocation { get; set; }

        //Paper Category one-to-many
        public PaperCategoryModel PaperCategory { get; set; }

        //Research Seminar one-to-one
        public ResearchSeminarModel ResearchSeminar { get; set; }

        //research Collaboration one-to-one
        public ResearchCollaborationModel ResearchCollaboration { get; set; }


    }
}
