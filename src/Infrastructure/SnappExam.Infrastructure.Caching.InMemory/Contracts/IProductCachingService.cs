using SnappExam.Core.Domain.Dtos.Products;

namespace SnappExam.Infrastructure.Caching.InMemory.Contracts
{
    public interface IProductCachingService
    {
        GetProdutDto GetProductDto(string key);
        void SetProductDto(string key, GetProdutDto value);
    }
}