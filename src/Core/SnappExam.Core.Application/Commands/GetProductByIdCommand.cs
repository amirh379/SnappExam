using MediatR;
using SnappExam.Core.Domain.Dtos.Products;

namespace SnappExam.Core.Application.Commands
{
    public record GetProductByIdCommand : IRequest<GetProdutDto>
    {
        public int Id { get; set; }
    }
}
