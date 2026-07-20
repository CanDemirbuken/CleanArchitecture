using CleanArchitecture.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CleanArchitecture.Infrastructure.Authorization;

public sealed class RoleAttribute(IUserRoleRepository userRoleRepository, string role) : Attribute, IAsyncAuthorizationFilter
{
    public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
    {
        var userIdClaim = context.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
        if (userIdClaim is null)
        {
            context.Result = new UnauthorizedResult();
            return;
        }

        var userHasRole = await userRoleRepository
            .Where(p => p.UserId == userIdClaim.Value)
            .Include(p => p.Role)
            .AnyAsync(p => p.Role.Name == role);

        if (!userHasRole)
        {
            context.Result = new UnauthorizedResult();
            return;
        }
    }
}
