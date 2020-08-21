using System.Collections.Generic;

namespace SSSApp.API.Models
{
    public class RallyEntry
    {
        public int RallyEntryId { get; set; }
        public int StartingNumber { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; }
        public int RallyId { get; set; }
        public virtual Rally Rally { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}