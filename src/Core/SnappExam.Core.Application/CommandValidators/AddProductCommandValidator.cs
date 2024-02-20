using FluentValidation;
using SnappExam.Core.Application.Commands;
using SnappExam.Core.Common.Resources;
namespace SnappExam.Core.Application.CommandValidators
{
    public class AddProductCommandValidator : AbstractValidator<AddProductCommand>
    {
        public AddProductCommandValidator()
        {
            RuleFor(a => a.Title).NotEmpty().MaximumLength(40).WithMessage(Messages.InvalidProductName);
        }
    }
}
