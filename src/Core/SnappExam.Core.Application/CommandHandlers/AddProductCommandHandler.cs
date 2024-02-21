using MediatR;
using SnappExam.Core.Application.Commands;
using SnappExam.Core.Common.Resources;
using SnappExam.Core.Domain.Models.Products;
using SnappExam.Infrastructure.Persistence.EF.Contracts;

namespace SnappExam.Core.Application.CommandHandlers
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, int>
    {
        readonly IProductRepository _productRepository;

        public AddProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<int> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            // Second Approach
            //var isExistsTitle = await _productRepository.IsProductTitleExists(request.Title,cancellationToken);
            //if (isExistsTitle) throw new ApplicationException(Messages.InvalidProductName);

            var product = Product.CreateInstance(request.Title, request.Price, request.Discount);
            return await _productRepository.AddProductAsync(product, cancellationToken);
        }
    }
}
