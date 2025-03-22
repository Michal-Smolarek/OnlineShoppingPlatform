using System.Text.Json.Serialization;

namespace OnlineShoppingPlatform.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category? Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsAvaliable { get; set; }

    }
}
