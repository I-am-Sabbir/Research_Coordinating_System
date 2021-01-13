using System;
using System.Collections.Generic;
using System.Text;
using Data;

namespace Framework.Entities
{
    public class PaperCategory : IEntity<int>
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public IList<PaperDetails> PaperDetails { get; set; }
    }
}
