using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace CleanArchitecture.WebApi.Configurations;

public sealed class AuthorizeServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration, IHostBuilder hostBuilder)
    {
        services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer();

        services.AddAuthorization();
    }
}
