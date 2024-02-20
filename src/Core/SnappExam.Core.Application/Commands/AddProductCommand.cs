using MediatR;
using SnappExam.Core.Common.Resources;
using System.ComponentModel.DataAnnotations;

namespace SnappExam.Core.Application.Commands
{
    public record AddProductCommand : IRequest<int>
    {        
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
    }
}
