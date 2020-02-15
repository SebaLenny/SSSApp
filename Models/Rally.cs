using System;
using System.Collections.Generic;

namespace SSSApp.API.Models
{
    public class Rally
    {
        public int RallyId { get; set; }
        public string RallyName { get; set; }
        public DateTime EventDate { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Entry> Entries { get; set; }
        public ICollection<Stage> Stages { get; set; }
    }
}