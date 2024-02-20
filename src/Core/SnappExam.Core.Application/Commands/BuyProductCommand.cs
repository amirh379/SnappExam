using MediatR;

namespace SnappExam.Core.Application.Commands
{
    public record BuyProductCommand : IRequest
    {
        public int BuyerId { get; set; }
        public int ProductId { get; set; }
    }
}
