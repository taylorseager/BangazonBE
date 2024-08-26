using System.ComponentModel.DataAnnotations;
namespace BackEnd.Models
{
	public class OrderItem
	{
        public int Id { get; set; }
        public int ProductId { get; set; } // Foreign Key to Product
        public int OrderId { get; set; } // Foreign Key to Order
        public int Quantity { get; set; }
    }
}

