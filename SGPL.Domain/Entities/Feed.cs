using SGPL.Domain.Base;

namespace SGPL.Domain.Entities
{
    public class Feed : BaseEntity<int>
    {
        public Feed() : base(0) 
        {
        }
        public Feed(int id, string feedType, decimal quantity ) : base(id)
        {
            FeedType = feedType;
            Quantity = quantity;
        }
        public string FeedType { get; set; }
        public decimal Quantity { get; set; }
    }
}
