using Infrastructure.Persistence.Ef;
using Microsoft.EntityFrameworkCore;
using SnappExam.Core.Domain.Dtos.Products;
using SnappExam.Core.Domain.Models.Products;
using SnappExam.Infrastructure.Persistence.EF.Contracts;

namespace SnappExam.Infrastructure.Persistence.EF.Repositories
{
    public class ProductRepository : IProductRepository
    {
        ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<int> AddProductAsync(Product product, CancellationToken cancellationToken)
        {
            var entry = await _context.Products.AddAsync(product, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return entry.Entity.Id;
        }

        public async Task<Product> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Products.FirstAsync(p => p.Id == id, cancellationToken);
        }

        public async Task<GetProdutDto> GetProductDtoByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Products
                .Select(z => new GetProdutDto { Id = z.Id, Discount = z.Discount, Price = z.Price })
                .AsNoTracking()
                .FirstAsync(p => p.Id == id, cancellationToken);
        }

        public async Task UpdateAsync(Product product, CancellationToken cancellationToken)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
