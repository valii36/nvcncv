namespace nvctask.Models
{
    public class TeamMember : BaseEntitiy
    {
        public string ImageUrl { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        List<SosialMedia> SosialMedias { get; set; }

    }
}
