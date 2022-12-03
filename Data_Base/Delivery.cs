namespace Data_Base
{
    public partial class Delivery
    {
        public int Id { get; set; }

        public string? Address { get; set; }

        public Product IdNavigation { get; set; } = null!;





        public int Quantity { get; set; }
    }
}