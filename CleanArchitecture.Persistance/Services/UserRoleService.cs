using CleanArchitecture.Application.Feature.UserRoleFeatures.Commands.CreateUserRole;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using GenericRepository;

namespace CleanArchitecture.Persistence.Services;

public sealed class UserRoleService(IUserRoleRepository userRoleRepository, IUnitOfWork unitOfWork) : IUserRoleService
{
    public async Task CreateUserRoleAsync(CreateUserRoleCommand request, CancellationToken cancellationToken)
    {
        UserRole userRole = new UserRole()
        {
            RoleId = request.RoleId,
            UserId = request.UserId
        };

        await userRoleRepository.AddAsync(userRole, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}