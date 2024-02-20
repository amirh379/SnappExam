using MediatR;
using SnappExam.Core.Application.Commands;
using SnappExam.Core.Domain.Models.Orders;
using SnappExam.Core.Domain.Models.Users;
using SnappExam.Infrastructure.Persistence.EF.Contracts;

namespace SnappExam.Core.Application.CommandHandlers
{
    public class BuyProductCommandHandler : IRequestHandler<BuyProductCommand>
    {
        readonly IRepository<User> _userRepository;
        readonly IRepository<Order> _orderRepository;
        readonly IProductRepository _productRepository;

        public BuyProductCommandHandler(IRepository<User> userRepository, IProductRepository productRepository, IRepository<Order> orderRepository)
        {
            _userRepository = userRepository;
            _productRepository = productRepository;
            _orderRepository = orderRepository;
        }

        public async Task Handle(BuyProductCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.BuyerId, cancellationToken);
            var product = await _productRepository.GetByIdAsync(request.ProductId, cancellationToken);
            product.DecreaseInventory().SetModificationTime();
            var order = Order.CreateInstance(product, user);
            await _orderRepository.Insert(order, cancellationToken);
        }
    }
}
