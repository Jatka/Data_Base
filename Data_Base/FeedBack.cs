namespace Data_Base
{
	public partial class FeedBack
	{
		public int Id
		{
			get; set;
		}
		public string? Title
		{
			get; set;
		}
        public int Quantity { get; set; }
        public int Rating { get; set; }
        public Product IdNavigation { get; set; } = null!;
	}
}