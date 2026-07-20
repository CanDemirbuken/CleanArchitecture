using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Persistance.Context;
using CleanArchitecture.Persistence.Repositories;
using CleanArchitecture.Persistence.Services;
using CleanArchitecture.WebApi.Middleware;
using GenericRepository;

namespace CleanArchitecture.WebApi.Configurations;

public class PersistanceDependencyInjectionServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration, IHostBuilder hostBuilder)
    {
        services.AddScoped<ICarRepository, CarRepository>();
        services.AddScoped<ICarService, CarService>();

        services.AddScoped<IAuthService, AuthService>();
        
        services.AddScoped<IRoleService, RoleService>();

        services.AddScoped<IUserRoleRepository, UserRoleRepository>();
        services.AddScoped<IUserRoleService, UserRoleService>();
        
        services.AddScoped<IUnitOfWork>(srv => srv.GetRequiredService<AppDbContext>());
        services.AddTransient<ExceptionMiddleware>();

    }
}
