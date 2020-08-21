using System.Collections.Generic;

namespace SSSApp.API.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int? CarCategoryId { get; set; }
        public virtual CarCategory CarCategory { get; set; }
        public virtual ICollection<RallyEntry> RallyEntries { get; set; }
    }
}