using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace Framework.Entities
{
    public class ResearchSeminar : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ResourcePerson { get; set; }
        public DateTime Date { get; set; }
        public string Vanue { get; set; }
        public string NumberOfParticipants { get; set; }

        public int PaperDetailsId { get; set; }
        public PaperDetails PaperDetails { get; set; }
    }
}
