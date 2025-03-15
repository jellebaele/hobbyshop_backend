using MediatR;

namespace Hobbyshop.Application.Users.Features.Commands.RegisterUser;

public sealed record  RegisterUserCommand(string Email, string Password): IRequest<RegisterUserCommandResponse>
{
    
}
