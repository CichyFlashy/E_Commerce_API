namespace ECommerceAPI.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string name { get; set; } = string.Empty;
        public decimal price { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
