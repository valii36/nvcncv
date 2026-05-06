namespace nvctask.Models
{
    public class TeamMember : BaseEntity
    {
        public string ImageUrl { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public List<SosialMedia> SosialMedias { get; set; }

    }
}
