using CleanArchitecture.Application.Common.Responses;
using CleanArchitecture.Application.Feature.CarFeatures.Queries.GetAllCar;
using CleanArchitecture.Application.Services;
using MediatR;

namespace CleanArchitecture.Application.Feature.CarFeatures.Queries.GetAllCarWithPagination;

public sealed class GetAllCarWithPaginationQueryHandler(ICarService carService) : IRequestHandler<GetAllCarWithPaginationQuery, PaginationResponse<GetAllCarResponse>>
{
    public async Task<PaginationResponse<GetAllCarResponse>> Handle(GetAllCarWithPaginationQuery request, CancellationToken cancellationToken)
    {
        PaginationResponse<GetAllCarResponse> cars = await carService.GetAllWithPaginationAsync(request, cancellationToken);
        return cars;
    }
}