using Infrastructure.Contexts;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Configurations;

public static class ServiceRegistration
{
    public static void RegisterServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<AccountService>();
    }
}
