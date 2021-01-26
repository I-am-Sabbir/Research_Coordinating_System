using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace Framework.Entities
{
    public class PaperDetails : IEntity<int>
    {
        public int Id { get; set; }
        public string PaperTilte { get; set; }
        public string AuthorName { get; set; }
        public string JournalorConferenceName { get; set; }
        public string Volume { get; set; }
        public string Page { get; set; }
        public string ConferenceLocation { get; set; }

        public DateTime Submitdate { get; set; }

        public int PaperCategoryId { get; set; }
        public PaperCategory PaperCategory { get; set; }

        public int ResearchSeminarId { get; set; }
        public ResearchSeminar ResearchSeminar { get; set; }

        public int ResearchCollaborationId { get; set; }
        public ResearchCollaboration ResearchCollaboration { get; set; }
    }
}
