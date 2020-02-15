using System.Collections.Generic;

namespace SSSApp.API.Models
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string DriverNick { get; set; }
        public int FavouriteNumber { get; set; }
        public ICollection<Entry> Entries { get; set; }        
    }
}