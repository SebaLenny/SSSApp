using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SSSApp.API.Models
{
    public class CarCategory
    {
        public int CarCategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<Rally> Rallies { get; set; }
    }
}