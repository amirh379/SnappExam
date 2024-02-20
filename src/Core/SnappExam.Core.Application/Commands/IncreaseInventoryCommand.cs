using MediatR;

namespace SnappExam.Core.Application.Commands
{
    public record IncreaseInventoryCommand : IRequest
    {
        public int ProductId { get; set; }
    }
}
