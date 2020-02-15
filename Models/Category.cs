using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SSSApp.API.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}