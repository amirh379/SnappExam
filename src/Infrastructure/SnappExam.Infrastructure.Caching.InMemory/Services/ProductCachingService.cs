using Microsoft.Extensions.Caching.Memory;
using SnappExam.Core.Domain.Dtos.Products;
using SnappExam.Infrastructure.Caching.InMemory.Contracts;

namespace SnappExam.Infrastructure.Caching.InMemory.Services
{
    public class ProductCachingService : IProductCachingService
    {
        IMemoryCache _memoryCache;
        TimeSpan CacheTimer = TimeSpan.FromMinutes(1);
        public ProductCachingService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public GetProdutDto GetProductDto(string key)
        {
            return _memoryCache.Get<GetProdutDto>(key);
        }

        public void SetProductDto(string key, GetProdutDto value)
        {
            _memoryCache.Set(key, value, CacheTimer);
        }
    }
}
