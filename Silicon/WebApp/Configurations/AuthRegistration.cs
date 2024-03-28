using Infrastructure.Contexts;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Configurations;

public static class AuthRegistration
{
    public static void RegisterAuthentication(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<DataContext>(x => x.UseSqlServer(config.GetConnectionString("SqlServer")));
        services.AddDefaultIdentity<UserEntity>(x =>
        {
            x.User.RequireUniqueEmail = true;
            x.SignIn.RequireConfirmedAccount = false;
            x.Password.RequiredLength = 8;
        }).AddEntityFrameworkStores<DataContext>();

        services.ConfigureApplicationCookie(x =>
        {
            x.LoginPath = "/signin";
        });
    }
}
