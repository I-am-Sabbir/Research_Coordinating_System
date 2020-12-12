using Membership.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Research_Coordinating_System.Models
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Require Task Name")]
        [Display(Name ="Task Name")]
        public string TaskName { get; set; }

        [Display(Name ="Dead Line")]
        public DateTime DeadLine { get; set; }

        public string File { get; set; }
    }
}
