using Microsoft.EntityFrameworkCore;

namespace nvctask.Models
{
    public class Portfolio : BaseEntity
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Client { get; set; }
        public DateTime ProjectDate { get; set; }
        public string ProjectUrl { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
    }
}
