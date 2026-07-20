using CleanArchitecture.Application.Abstractions;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Infrastructure.Authentication;
using CleanArchitecture.Infrastructure.Options;
using CleanArchitecture.Infrastructure.Services;
using CleanArchitecture.WebApi.OptionsSetup;

namespace CleanArchitecture.WebApi.Configurations;

public sealed class InfrastructureDependencyInjectionServiceInstaller : IServiceInstaller
{
    public void Install(IServiceCollection services, IConfiguration configuration, IHostBuilder hostBuilder)
    {
        services.AddScoped<IJwtProvider, JwtProvider>();

        services.ConfigureOptions<JwtOptionsSetup>();
        services.ConfigureOptions<JwtBearerOptionsSetup>();

        services.AddScoped<IMailService, MailService>();
        services
            .AddOptions<MailSettings>()
            .Bind(configuration.GetSection(MailSettings.SectionName))
            .Validate(settings =>
                    !string.IsNullOrWhiteSpace(settings.Host),
                "Mail host bilgisi zorunludur.")
            .Validate(settings =>
                    settings.Port > 0,
                "Mail port bilgisi geçerli olmalıdır.")
            .Validate(settings =>
                    !string.IsNullOrWhiteSpace(settings.SenderEmail),
                "Gönderen mail adresi zorunludur.")
            .ValidateOnStart();
    }
}