namespace ECommerceAPI.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
