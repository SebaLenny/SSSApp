namespace SSSApp.API.Models
{
    public class ClubRally
    {
        public int ClubId { get; set; }
        public virtual Club Club { get; set; }
        public int RallyId { get; set; }
        public virtual Rally Rally { get; set; }
    }
}