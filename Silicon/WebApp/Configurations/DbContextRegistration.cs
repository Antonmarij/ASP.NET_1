using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Configurations;

public static class DbContextRegistration
{
    public static void RegisterDbContexts(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<CoursesDbContext>(x => x.UseSqlServer(config.GetConnectionString("SqlServer")));
    } 
}
