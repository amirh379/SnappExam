namespace SnappExam.Core.Domain.Core
{
    public interface IEntity
    {
    }

    public abstract class BaseEntity<TKey> : IEntity
    {
        public TKey Id { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDelete { get; set; } = false;
        public DateTime InsertionTime { get; set; }
        public DateTime ModificationTime { get; set; } = DateTime.Now;        
    }

    public abstract class BaseEntity : BaseEntity<int>
    {
    }
}