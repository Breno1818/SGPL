using SGPL.Domain.Base;

namespace SGPL.Domain.Entities
{
    public class Production : BaseEntity<int>
    {
       public Production() : base(0)
        {
        }
        public Production(int id, string product, int quantity, Feed feed ) : base(id)
        {
            Product = product;
            Quantity = quantity;
            Feed = feed;
        }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public Feed Feed { get; set; }
    }
}