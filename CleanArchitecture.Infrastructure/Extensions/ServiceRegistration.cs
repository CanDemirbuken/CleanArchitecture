using CleanArchitecture.Application.Services;
using CleanArchitecture.Infrastructure.Options;
using CleanArchitecture.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure.Extensions;

public static class ServiceRegistration
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
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

        services.AddScoped<IMailService, MailService>();

        return services;
    }
}