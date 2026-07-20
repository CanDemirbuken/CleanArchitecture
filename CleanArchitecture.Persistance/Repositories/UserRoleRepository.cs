using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Persistance.Context;
using GenericRepository;

namespace CleanArchitecture.Persistence.Repositories;

public sealed class UserRoleRepository(AppDbContext context) : Repository<UserRole, AppDbContext>(context), IUserRoleRepository { }