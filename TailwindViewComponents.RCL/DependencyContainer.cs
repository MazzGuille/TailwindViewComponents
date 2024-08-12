using Microsoft.Extensions.DependencyInjection;
using TailwindViewComponents.RCL.Services.Buttons;

namespace TailwindViewComponents.RCL;
public static class DependencyContainer
{
    public static IServiceCollection DepencyRCL(this IServiceCollection services)
    {
        services.AddScoped<IBtnService, BtnService>();
        return services;
    }
}
