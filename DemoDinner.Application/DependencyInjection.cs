using DemoDinner.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace DemoDinner.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}
