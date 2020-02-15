using System;

namespace SSSApp.API.Models
{
    public class Result
    {
        public int ResultId { get; set; }
        public TimeSpan Time { get; set; }
        public bool DNF { get; set; }
        public int EntryId { get; set; }
        public Entry Entry { get; set; }
        public int StageId { get; set; }
        public Stage Stage { get; set; }
    }
}