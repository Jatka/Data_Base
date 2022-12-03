namespace Data_Base
{
    public partial class CustomerProfile
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? PhoneNumber { get; set; }
        public int Quantity { get; set; }
        public string? Address { get; set; }

        public Company IdNavigation { get; set; } = null!;




    }
}