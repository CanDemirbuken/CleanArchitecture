using CleanArchitecture.Application.Feature.RoleFeatures.Commands.CreateRole;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Persistence.Services;

public sealed class RoleService(RoleManager<Role> roleManager) : IRoleService
{
    public async Task CreateAsync(CreateRoleCommand request)
    {
        Role role = new Role()
        {
            Name = request.Name
        };

        await roleManager.CreateAsync(role);
    }
}
