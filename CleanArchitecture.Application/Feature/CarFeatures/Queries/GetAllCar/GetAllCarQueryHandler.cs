using CleanArchitecture.Application.Services;
using MediatR;

namespace CleanArchitecture.Application.Feature.CarFeatures.Queries.GetAllCar;

public sealed class GetAllCarQueryHandler(ICarService carService) : IRequestHandler<GetAllCarQuery, IList<GetAllCarResponse>>
{
    public async Task<IList<GetAllCarResponse>> Handle(GetAllCarQuery request, CancellationToken cancellationToken)
    {
        IList<GetAllCarResponse> cars = await carService.GetAllAsync(request, cancellationToken);
        return cars;
    }
}
