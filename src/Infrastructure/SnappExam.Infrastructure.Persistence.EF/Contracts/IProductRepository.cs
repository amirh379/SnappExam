using SnappExam.Core.Domain.Dtos.Products;
using SnappExam.Core.Domain.Models.Products;

namespace SnappExam.Infrastructure.Persistence.EF.Contracts
{
    public interface IProductRepository
    {
        Task<int> AddProductAsync(Product product, CancellationToken cancellationToken);
        Task<Product> GetByIdAsync(int id, CancellationToken cancellationToken);
        Task<GetProdutDto> GetProductDtoByIdAsync(int id, CancellationToken cancellationToken);
        Task UpdateAsync(Product product, CancellationToken cancellationToken);
    }
}
