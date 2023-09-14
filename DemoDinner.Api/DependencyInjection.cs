using DemoDinner.Api.Common.Errors;
using DemoDinner.Api.Common.Mapping;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace DemoDinner.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, DemoDinnerProblemDetailsFactory>();
        services.AddMappings();

        return services;
    }
}
