using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SnappExam.Core.Application.Commands;
using SnappExam.Core.Domain.Dtos.Products;
using SnappExam.Infrastructure.Configuration.Models;

namespace SnappExam.Presentation.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private IValidator<AddProductCommand> _validator;
        public ProductsController(IMediator mediator, IValidator<AddProductCommand> validator)
        {
            _mediator = mediator;
            _validator = validator;
        }

        [HttpPost]
        public async Task<ApiResult<string>> Post(AddProductCommand command, CancellationToken cancellationToken)
        {
            ValidationResult result = await _validator.ValidateAsync(command);
            if (!result.IsValid) return BadRequest(result.Errors);
            var id = await _mediator.Send(command, cancellationToken);
            return Ok(id);
        }


        [HttpPatch]
        public async Task<ApiResult> IncreaseInventory(IncreaseInventoryCommand command, CancellationToken cancellationToken)
        {
            await _mediator.Send(command, cancellationToken);
            return Ok();
        }

        [HttpGet]
        //[ResponseCache]
        public async Task<ApiResult<GetProdutDto>> Get([FromQuery] GetProductByIdCommand command, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(command, cancellationToken);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ApiResult> Buy(BuyProductCommand command, CancellationToken cancellationToken)
        {
            await _mediator.Send(command, cancellationToken);
            return Ok();
        }
    }
}
