using CleanArchitecture.Application.Feature.RoleFeatures.Commands.CreateRole;
using CleanArchitecture.Domain.Dtos;
using CleanArchitecture.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controllers;

public sealed class RolesController(IMediator mediator) : ApiController(mediator)
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        MessageResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}