using SnappExam.Core.Domain.Core;
using SnappExam.Core.Domain.Models.Orders;

namespace SnappExam.Core.Domain.Models.Users
{
    public class User : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
