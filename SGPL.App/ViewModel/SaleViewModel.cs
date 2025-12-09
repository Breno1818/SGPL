namespace SGPL.App.ViewModel
{
    public class SaleViewModel
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal SaleTotal { get; set; }
        public int IdSalesman { get; set; }
        public string? Salesman { get; set; }
    }

    public class SaleItemViewModel
    {
        public int Id { get; set; }
        public string? Sale { get; set; }
        public int IdProduction { get; set; }
        public string? Production { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
