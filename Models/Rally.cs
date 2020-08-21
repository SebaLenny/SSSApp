using System;
using System.Collections.Generic;

namespace SSSApp.API.Models
{
    public class Rally
    {
        public int RallyId { get; set; }
        public string RallyName { get; set; }
        public DateTime EventDate { get; set; }
        public int? CarCategoryId { get; set; }
        public virtual CarCategory CarCategory { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<RallyEntry> RallyEntries { get; set; }
        public virtual ICollection<Stage> Stages { get; set; }
    }
}