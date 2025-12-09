using SGPL.Domain.Base;
using SGPL.Domain.Entities;

namespace SGPL.Domain.Entities
{
    public class Sale : BaseEntity<int>
    {

        public Sale() : base(0)
        {
            SaleItems = new List<SaleItem>();
        }
        public Sale(int id, DateTime saleDate, decimal saleTotal, User salesman) : base(id)
        {
            SaleDate = saleDate;
            SaleTotal = saleTotal;
            Salesman = salesman;
            SaleItems = new List<SaleItem>();
        }
        public DateTime SaleDate { get; set; }
        public decimal SaleTotal { get; set; }
        public User Salesman { get; set; }
        public List<SaleItem> SaleItems { get; set; }

    }

    public class SaleItem : BaseEntity<int>
    {

        public SaleItem() : base(0)
        {
        }
        public SaleItem(int id, Sale sale, Production production, int quantity, decimal unitPrice, decimal totalPrice) : base(id)
        {
            Sale = sale;
            Production = production;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
        }
        public Sale Sale { get; set; }
        public Production Production { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
