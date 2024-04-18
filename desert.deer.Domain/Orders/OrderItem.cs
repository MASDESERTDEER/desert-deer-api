using desert.deer.Domain.Catalog;

namespace desert.deer.Domain.Orders{
     public class OrderItem
    {
        public int Id { get; set; }
        public OrderItem? Item { get; set; }
        public int Quantity { get; set; }
        public decimal Price => Item.Price * Quantity;
    }
}