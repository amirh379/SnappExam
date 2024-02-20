using MediatR;
using SnappExam.Core.Application.Commands;
using SnappExam.Infrastructure.Persistence.EF.Contracts;

namespace SnappExam.Core.Application.CommandHandlers
{
    public class IncreaseInventoryCommandHandler : IRequestHandler<IncreaseInventoryCommand>
    {
        readonly IProductRepository _productRepository;

        public IncreaseInventoryCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task Handle(IncreaseInventoryCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.ProductId, cancellationToken);
            product.IncreaseInventory().SetModificationTime();
            await _productRepository.UpdateAsync(product, cancellationToken);
        }
    }
}
