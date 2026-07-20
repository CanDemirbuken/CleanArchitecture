using CleanArchitecture.Application.Feature.UserRoleFeatures.Commands.CreateUserRole;
using CleanArchitecture.Domain.Dtos;
using CleanArchitecture.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controllers;

public sealed class UserRolesController(IMediator mediator) : ApiController(mediator)
{
    [HttpPost]
    public async Task<IActionResult> CreateUserRoleAsync(CreateUserRoleCommand request, CancellationToken cancellationToken)
    {
        MessageResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}
