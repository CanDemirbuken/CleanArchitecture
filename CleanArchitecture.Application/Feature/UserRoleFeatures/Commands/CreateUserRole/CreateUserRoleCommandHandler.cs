using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Application.Feature.UserRoleFeatures.Commands.CreateUserRole;

public sealed class CreateUserRoleCommandHandler(IUserRoleService userRoleService) : IRequestHandler<CreateUserRoleCommand, MessageResponse>
{
    public async Task<MessageResponse> Handle(CreateUserRoleCommand request, CancellationToken cancellationToken)
    {
        await userRoleService.CreateUserRoleAsync(request, cancellationToken);
        return new MessageResponse("Kullanıcıya rol başarıyla atandı!");
    }
}
