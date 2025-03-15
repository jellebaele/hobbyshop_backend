using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Hobbyshop.Api.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class UserController: ControllerBase
{
    [HttpGet(Name = "user")]
    public Task<IActionResult> Get(string id)
    {
        return Task.FromResult<IActionResult>(Ok(new { Id = id }));
    }
    
}
