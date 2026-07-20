using CleanArchitecture.Application.Feature.UserRoleFeatures.Commands.CreateUserRole;

namespace CleanArchitecture.Application.Services;

public interface IUserRoleService
{
    Task CreateUserRoleAsync(CreateUserRoleCommand request, CancellationToken cancellationToken);
}
