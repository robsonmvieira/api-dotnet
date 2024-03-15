using MediatR;
using Microsoft.AspNetCore.Mvc;
using Stock.Supplier.Application.UseCases.Common;
using Stock.Supplier.Application.UseCases.Supplier.CreateSupplierUseCase.Dtos;
using Stock.Supplier.Application.UseCases.Supplier.ListSupplierUseCase.Dtos;

namespace Stock.Supplier.Application.Controllers;


// add controller decorator

[Route("api/[controller]")]
public class SupplierController: MainController
{
    // inject private readonly IMediator _mediator
    private readonly IMediator _mediator;
    
    public SupplierController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        
        var response = await  _mediator.Send(new ListSupplierUseCaseDto(), cancellationToken);
        return Ok(response);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        return Ok();
    }
    // add route decorator
    [HttpPost]
    [ProducesResponseType(typeof(BaseUseCaseResponse<SupplierOutput>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status422UnprocessableEntity)]
    public async Task<IActionResult> Post([FromBody] CreateSupplierDto request, CancellationToken cancellationToken)
    
    {
        var supplier = _mediator.Send(request, cancellationToken);
        var response = new BaseUseCaseResponse<SupplierOutput>(false, true, null);
        return Ok();
    }
    // add route decorator
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(Guid id)
    {
        return Ok();
    }
    // add route decorator
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        return Ok();
    }
     
}