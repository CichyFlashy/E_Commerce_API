using System.ComponentModel.DataAnnotations;

namespace ECommerceAPI.Models
{
    public class OrderDetail
    {
        public int OrderID { get; set; }

        public required Order Order { get; set; }

        public int ProductID { get; set; }
        public required Product Product { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
        public int Quantity { get; set; }

        [Range(0, 1000000, ErrorMessage = "The order price must be greater than or equal to 0")]
        public decimal OrderPrice { get; set; }

    }
}
