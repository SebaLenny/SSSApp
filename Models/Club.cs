using System.Collections.Generic;

namespace SSSApp.API.Models
{
    public class Club
    {
        public int ClubId { get; set; }
        public string ClubName { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
    }
}