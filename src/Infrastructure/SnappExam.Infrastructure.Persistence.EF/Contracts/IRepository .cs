using SnappExam.Core.Domain.Core;

namespace SnappExam.Infrastructure.Persistence.EF.Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id, CancellationToken cancellationToken);
        Task Insert(T entity, CancellationToken cancellationToken);
        Task<List<T>> GetAll(CancellationToken cancellationToken);
    }
}
