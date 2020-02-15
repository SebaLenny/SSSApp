using System.Collections.Generic;

namespace SSSApp.API.Models
{
    public class Entry
    {
        public int EntryId { get; set; }
        public int StartingNumber { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
        public ICollection<Rally> Rallies { get; set; }
        public ICollection<Result> Results { get; set; }
    }
}