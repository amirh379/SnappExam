using MediatR;
using SnappExam.Core.Common.Resources;
using System.ComponentModel.DataAnnotations;

namespace SnappExam.Core.Application.Commands
{
    public record AddProductCommand : IRequest<int>
    {
        public AddProductCommand(string title, decimal price, int discount)
        {
            Title = title;
            Price = price;
            Discount = discount;
        }

        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
    }
}
