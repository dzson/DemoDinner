using DemoDinner.Application.Common.Interfaces.Authentication;
using DemoDinner.Application.Common.Interfaces.Persistence;
using DemoDinner.Application.Common.Interfaces.Services;
using DemoDinner.Infrastructure.Authentication;
using DemoDinner.Infrastructure.Persistence;
using DemoDinner.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDinner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}
