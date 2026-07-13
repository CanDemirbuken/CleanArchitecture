using AutoMapper;
using CleanArchitecture.Application.Feature.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistance.Context;

namespace CleanArchitecture.Persistance.Services;

public sealed class CarService(AppDbContext context, IMapper mapper) : ICarService
{
    public async Task CreateAsync(CreateCarCommand request, CancellationToken cancellationToken)
    {
        Car car = mapper.Map<Car>(request);

        await context.Set<Car>().AddAsync(car, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
}