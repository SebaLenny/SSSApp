using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace SSSApp.API.Models
{
    public class Driver : IdentityUser<int>
    {
        public int FavouriteNumber { get; set; }
        public virtual ICollection<RallyEntry> RallyEntries { get; set; }   
        public int? ClubId { get; set; }     
        public virtual Club Club { get; set; }     
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}