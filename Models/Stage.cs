using System.Collections.Generic;

namespace SSSApp.API.Models
{
    public class Stage
    {
        public int StageId { get; set; }
        public int RallyId { get; set; }
        public virtual Rally Rally { get; set; }
        public int TrackId { get; set; }
        public virtual Track Track { get; set; }
        public int? ConditionsId { get; set; }
        public virtual Conditions Conditions { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}