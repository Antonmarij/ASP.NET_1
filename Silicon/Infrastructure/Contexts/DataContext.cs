using Infrastructure.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext<UserEntity>(options)
{
    public DbSet<SubscriberEntity> Subscribers { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.HasDefaultSchema("identity");
    //}
}

public class CoursesDbContext(DbContextOptions<CoursesDbContext> options) : DbContext(options)
{
    public DbSet<CourseEntity> Courses { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.HasDefaultSchema("courses");
    //}
}