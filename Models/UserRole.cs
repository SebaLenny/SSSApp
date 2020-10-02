using Microsoft.AspNetCore.Identity;

namespace SSSApp.API.Models
{
    public class UserRole : IdentityUserRole<int>
    {
        public virtual Driver User { get; set; }
        public virtual Role Role { get; set; }
    }
}