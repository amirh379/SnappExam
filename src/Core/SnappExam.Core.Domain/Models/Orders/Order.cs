using SnappExam.Core.Domain.Core;
using SnappExam.Core.Domain.Models.Products;
using SnappExam.Core.Domain.Models.Users;

namespace SnappExam.Core.Domain.Models.Orders
{
    public class Order : BaseEntity
    {
        private Order()
        {
            
        }
        public Product Product { get; set; }
        public DateTime CreationDate { get; set; }
        public User Buyer { get; set; }

        public static Order CreateInstance(Product product, User buyer)
        {
            return new Order()
            {
                Product = product,
                Buyer = buyer,                
                InsertionTime = DateTime.Now,
                CreationDate = DateTime.Now,
            };
        }
    }
}
