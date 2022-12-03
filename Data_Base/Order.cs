namespace Data_Base
{
    public partial class Order
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public decimal? Price { get; set; }

        public DateTime? CreatedDate { get; set; }
        public int Quantity { get; set; }
        public Company IdNavigation { get; set; } = null!;
        public int CompanyId { get; set; }
        public Product? Product { get; set; }
        public int ProductId { get; set; }


    }
}