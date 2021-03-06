﻿ using Data;
using Membership.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Entities
{
    public class Task : IEntity<int>
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public DateTime DeadLine { get; set; }
        public string File { get; set; }
        public string TaskAuthor { get; set; }
        public string AssignesTo { get; set; }

        //Problem
        //public Guid UserId { get; set; }
        //public ApplicationUser ApplicationUser { get; set; }
    }
}
