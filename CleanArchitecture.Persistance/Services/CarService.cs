using AutoMapper;
using CleanArchitecture.Application.Common.Responses;
using CleanArchitecture.Application.Feature.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Application.Feature.CarFeatures.Queries.GetAllCar;
using CleanArchitecture.Application.Feature.CarFeatures.Queries.GetAllCarWithPagination;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Services;

public sealed class CarService(ICarRepository carRepository, IUnitOfWork unitOfWork, IMapper mapper) : ICarService
{
    public async Task CreateAsync(CreateCarCommand request, CancellationToken cancellationToken)
    {
        Car car = mapper.Map<Car>(request);

        //await context.Set<Car>().AddAsync(car, cancellationToken);
        //await context.SaveChangesAsync(cancellationToken);

        await carRepository.AddAsync(car, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task<IList<GetAllCarResponse>> GetAllAsync(GetAllCarQuery request, CancellationToken cancellationToken)
    {
        IList<GetAllCarResponse> cars = await carRepository.
            GetAll()
            .Select(c => new GetAllCarResponse(c.Id, c.Name, c.Model, c.EnginePower))
            .ToListAsync(cancellationToken);

        return cars;
    }

    public async Task<PaginationResponse<GetAllCarResponse>> GetAllWithPaginationAsync(GetAllCarWithPaginationQuery request, CancellationToken cancellationToken)
    {
        IQueryable<Car> query = carRepository.GetAll();

        if (!string.IsNullOrWhiteSpace(request.Search))
        {
            query = query.Where(p =>
                EF.Functions.Like(p.Name, $"%{request.Search}%"));
        }

        int totalCount = await query.CountAsync(cancellationToken);

        IList<GetAllCarResponse> cars = await query
            .OrderBy(p => p.Id)
            .Skip((request.PageNumber - 1) * request.PageSize)
            .Take(request.PageSize)
            .Select(c => new GetAllCarResponse(c.Id, c.Name, c.Model, c.EnginePower))
            .ToListAsync(cancellationToken);

        int totalPages = (int)Math.Ceiling(totalCount / (double)request.PageSize);

        return new PaginationResponse<GetAllCarResponse>
        {
            Items = cars,
            PageNumber = request.PageNumber,
            PageSize = request.PageSize,
            TotalCount = totalCount,
            TotalPages = totalPages
        };
    }
}