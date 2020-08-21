using System;

namespace SSSApp.API.Models
{
    public class Result
    {
        public int ResultId { get; set; }
        public TimeSpan Time { get; set; }
        public bool DNF { get; set; }
        public int RallyEntryId { get; set; }
        public virtual RallyEntry RallyEntry { get; set; }
        public int StageId { get; set; }
        public virtual Stage Stage { get; set; }
    }
}