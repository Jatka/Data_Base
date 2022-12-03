namespace Data_Base
{
	public partial class Product
	{
		public int Id
		{
			get; set;
		}
		public string? Name
		{
			get; set;
		}
		public string? Description
		{
			get; set;
		}
		public decimal? Price
		{
			get; set;
		}
		public int Quantity { get; set; }
		public Delivery? Delivery { get; set; }
		public FeedBack? FeedBack { get; set; }

		public List<Order> Id1 { get; set; } = new();
		public Company IdNavigation { get; set; } = null!;
		public PackageList? PackageList { get; set; }
	}
}