using MediatR;
using SnappExam.Core.Application.Commands;
using SnappExam.Core.Domain.Dtos.Products;
using SnappExam.Infrastructure.Caching.InMemory.Contracts;
using SnappExam.Infrastructure.Persistence.EF.Contracts;

namespace SnappExam.Core.Application.CommandHandlers
{
    public class GetProductByIdCommandHandler : IRequestHandler<GetProductByIdCommand, GetProdutDto>
    {
        readonly IProductRepository _productRepository;
        readonly IProductCachingService _productCaching;

        public GetProductByIdCommandHandler(IProductRepository productRepository, IProductCachingService productCaching)
        {
            _productRepository = productRepository;
            _productCaching = productCaching;
        }

        public async Task<GetProdutDto> Handle(GetProductByIdCommand request, CancellationToken cancellationToken)
        {
            //Manual Caching
            var cacheResult = _productCaching.GetProductDto($"pDto-{request.Id}");
            if (cacheResult is not null) return cacheResult;
            
             var productDto = await _productRepository.GetProductDtoByIdAsync(request.Id, cancellationToken);
            _productCaching.SetProductDto($"pDto-{productDto.Id}", productDto);
            return productDto;
        }
    }
}
