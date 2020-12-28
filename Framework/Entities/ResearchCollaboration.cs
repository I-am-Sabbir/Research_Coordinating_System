using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Entities
{
    public class ResearchCollaboration : IEntity<int>
    {
        public int Id { get; set; }
        public string PartnerName { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        //public int PaperDetailsId { get; set; }
        public PaperDetails PaperDetails { get; set; }

    }
}
