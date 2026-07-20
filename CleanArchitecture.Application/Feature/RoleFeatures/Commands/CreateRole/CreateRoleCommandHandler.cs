using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Application.Feature.RoleFeatures.Commands.CreateRole;

public sealed class CreateRoleCommandHandler(IRoleService roleService) : IRequestHandler<CreateRoleCommand, MessageResponse>
{
    public async Task<MessageResponse> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        await roleService.CreateAsync(request);
        return new MessageResponse("Rol kaydı başarıyla tamamlandı!");
    }
}
