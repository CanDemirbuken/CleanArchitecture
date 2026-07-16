using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Persistance.Context;
using GenericRepository;

namespace CleanArchitecture.Persistence.Repositories;

public sealed class CarRepository(AppDbContext context) : Repository<Car, AppDbContext>(context), ICarRepository
{
}