namespace Data_Base
{
    public partial class PackageList
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public Product IdNavigation { get; set; } = null!;
    }
}