namespace ECommerceAPI.Models
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public required ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    }

}
