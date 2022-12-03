namespace Data_Base
{
    public partial class Company
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Inn { get; set; }

        public CustomerProfile? CustomerProfile { get; set; }

        public Order? Order { get; set; }

        public Product? Product { get; set; }
    }
}