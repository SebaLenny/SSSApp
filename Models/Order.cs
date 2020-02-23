using System.Collections.Generic;

namespace SSSApp.API.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public ICollection<Rally> Rallies { get; set; }
    }
}