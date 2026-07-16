using CleanArchitecture.Application.Common.Responses;
using CleanArchitecture.Application.Feature.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Application.Feature.CarFeatures.Queries.GetAllCar;
using CleanArchitecture.Application.Feature.CarFeatures.Queries.GetAllCarWithPagination;

namespace CleanArchitecture.Application.Services;

public interface ICarService
{
    Task CreateAsync(CreateCarCommand request, CancellationToken cancellationToken);
    Task<IList<GetAllCarResponse>> GetAllAsync(GetAllCarQuery request, CancellationToken cancellationToken);
    Task<PaginationResponse<GetAllCarResponse>> GetAllWithPaginationAsync(GetAllCarWithPaginationQuery request, CancellationToken cancellationToken);
}