using SnappExam.Core.Domain.Core;

namespace SnappExam.Core.Domain.Models.Products
{
    public class Product : BaseEntity
    {
        private Product()
        {

        }

        public string Title { get; set; }
        public int InventoryCount { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }

        public static Product CreateInstance(string title, decimal price, int discount)
        {
            return new Product()
            {
                Title = title,
                InventoryCount = 5,
                Price = price,
                Discount = discount,
                InsertionTime = DateTime.Now,
            };
        }
        public Product IncreaseInventory()
        {
            InventoryCount ++;
            return this;
        }
        public Product DecreaseInventory()
        {
            InventoryCount --;
            return this;
        }
        public Product SetModificationTime()
        {
            ModificationTime = DateTime.Now;
            return this;
        }
    }
}
