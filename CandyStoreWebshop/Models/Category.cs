using System.ComponentModel.DataAnnotations;

namespace CandyStoreWebshop.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Candy> Candies { get; set; }
    }
}
