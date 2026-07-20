using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Abstraction;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public abstract class ApiController(IMediator mediator) : ControllerBase
{
    public readonly IMediator _mediator = mediator;
}