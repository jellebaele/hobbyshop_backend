using Asp.Versioning;
using Hobbyshop.Application.Users.Features.Commands.RegisterUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hobbyshop.Api.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class UserController(ISender sender) : BaseApiController(sender)
{
    [HttpGet(Name = "user")]
    public Task<IActionResult> Get(string id)
    {
        return Task.FromResult<IActionResult>(Ok(new { Id = id }));
    }

    [HttpPost(Name = "user")]
    public async Task<ActionResult<RegisterUserCommandResponse>> RegisterUser([FromBody] RegisterUserCommand command)
    {
        var dto = await Sender.Send(command);
        return Ok(dto);
    }
    
}
