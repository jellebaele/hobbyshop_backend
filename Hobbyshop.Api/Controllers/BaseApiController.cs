using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Hobbyshop.Api.Controllers;

public abstract class BaseApiController: ControllerBase
{
    protected readonly ISender Sender;

    protected BaseApiController(ISender sender)
    {
        Sender = sender;
    }
}
