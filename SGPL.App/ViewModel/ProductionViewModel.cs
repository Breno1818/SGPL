namespace SGPL.App.ViewModels
{
    public class ProductionViewModel
    {
        public int Id { get; set; }
        public string? Product { get; set; }
        public int Quantity { get; set; }
        public int FeedId { get; set; }
        public string? FeedType { get; set; }
    }
}