using {{project_name}}.Application.CreateHelloWorld;

namespace {{project_name}}.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly IMediator _mediator;

    public CustomerController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [ProducesResponseType(typeof(LoadCustomerResult), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(StackSpot.ErrorHandler.HttpResponse), (int)HttpStatusCode.BadRequest)]
    [ProducesResponseType(typeof(StackSpot.ErrorHandler.HttpResponse), (int)HttpStatusCode.NoContent)]
    public async Task<IActionResult> Post([FromBody] LoadCustomerCommand command)
    {
        var result = await _mediator.Send(command);
        if(string.IsNullOrEmpty(result?.Id))
            return NoContent();
        else
            return Ok(result);
    }
}