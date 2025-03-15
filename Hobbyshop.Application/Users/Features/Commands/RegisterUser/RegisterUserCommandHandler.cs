using MediatR;

namespace Hobbyshop.Application.Users.Features.Commands.RegisterUser;

public class RegisterUserCommandHandler: IRequestHandler<RegisterUserCommand, RegisterUserCommandResponse>
{
    public Task<RegisterUserCommandResponse> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new RegisterUserCommandResponse(Guid.NewGuid(), request.Email));
    }
}
