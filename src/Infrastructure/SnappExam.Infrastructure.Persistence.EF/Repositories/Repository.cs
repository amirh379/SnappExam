using Infrastructure.Persistence.Ef;
using Microsoft.EntityFrameworkCore;
using SnappExam.Core.Domain.Core;
using SnappExam.Infrastructure.Persistence.EF.Contracts;

namespace SnappExam.Infrastructure.Persistence.EF.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        ApplicationDbContext _context;
        private DbSet<T> _entities;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task<T> GetByIdAsync(int id, CancellationToken cancellationToken)        
        {
            return await _entities.FirstAsync(d => d.Id == id);
        }

        public async Task Insert(T entity, CancellationToken cancellationToken)
        {
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
    }
}
