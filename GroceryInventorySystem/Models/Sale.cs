namespace GroceryInventorySystem.Models
{
    public class Sale
    {
        public int SaleID { get; set; }

        public string CustomerName { get; set; } = "";

        public string PaymentMethod { get; set; } = "";

        public string PaymentStatus { get; set; } = "";

        public string DeliveryStatus { get; set; } = "";

        public int TotalItems { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime SaleDate { get; set; }
    }
}