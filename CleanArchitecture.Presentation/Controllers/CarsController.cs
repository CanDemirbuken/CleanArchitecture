using CleanArchitecture.Application.Common.Responses;
using CleanArchitecture.Application.Feature.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Application.Feature.CarFeatures.Queries.GetAllCar;
using CleanArchitecture.Application.Feature.CarFeatures.Queries.GetAllCarWithPagination;
using CleanArchitecture.Domain.Dtos;
using CleanArchitecture.Infrastructure.Authorization;
using CleanArchitecture.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controllers
{
    public sealed class CarsController(IMediator mediator) : ApiController(mediator)
    {
        [RoleFilter("Create")]
        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateCarCommand request, CancellationToken cancellationToken)
        {
            MessageResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [RoleFilter("GetAll")]
        [HttpGet]
        [ProducesResponseType(typeof(IList<GetAllCarResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            IList<GetAllCarResponse> response = await _mediator.Send(new GetAllCarQuery(), cancellationToken);
            return Ok(response);
        }

        [HttpGet("[action]")]
        [ProducesResponseType(typeof(PaginationResponse<GetAllCarResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllWithPagination([FromQuery] GetAllCarWithPaginationQuery request, CancellationToken cancellationToken)
        {
            PaginationResponse<GetAllCarResponse> response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
