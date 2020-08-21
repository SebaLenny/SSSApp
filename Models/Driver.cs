using System.Collections.Generic;

namespace SSSApp.API.Models
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string DriverNick { get; set; }
        public int FavouriteNumber { get; set; }
        public virtual ICollection<RallyEntry> RallyEntries { get; set; }   
        public int? ClubId { get; set; }     
        public virtual Club Club { get; set; }     
    }
}