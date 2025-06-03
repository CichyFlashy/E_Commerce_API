namespace ECommerceAPI.Models
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }

    }

}
