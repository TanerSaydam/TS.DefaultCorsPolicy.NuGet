using Microsoft.Extensions.DependencyInjection;

namespace DefaultCorsPolicyNugetPackage;
public static class DefaultCorsPolicy
{
    public static IServiceCollection AddDefaultCors(this IServiceCollection services)
    {
        services.AddCors(cfr =>
        {
            cfr.AddDefaultPolicy(policy =>
            {
                policy
                    .AllowAnyHeader()
                    .AllowAnyMethod() 
                    .AllowCredentials()
                    .SetIsOriginAllowed(policy => true);
            });
        });

        return services;
    }
}
