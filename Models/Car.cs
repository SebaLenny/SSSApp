using System.Collections.Generic;

namespace SSSApp.API.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Entry> Entries { get; set; }
    }
}