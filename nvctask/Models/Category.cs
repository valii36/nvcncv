namespace nvctask.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
         public ICollection<Portfolio> Portfolios { get; set; }
    }
}
