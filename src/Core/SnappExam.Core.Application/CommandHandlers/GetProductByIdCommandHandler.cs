using MediatR;
using SnappExam.Core.Application.Commands;
using SnappExam.Core.Domain.Dtos.Products;
using SnappExam.Infrastructure.Persistence.EF.Contracts;

namespace SnappExam.Core.Application.CommandHandlers
{
    public class GetProductByIdCommandHandler : IRequestHandler<GetProductByIdCommand, GetProdutDto>
    {
        readonly IProductRepository _productRepository;

        public GetProductByIdCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<GetProdutDto> Handle(GetProductByIdCommand request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductDtoByIdAsync(request.Id, cancellationToken);
        }
    }
}
