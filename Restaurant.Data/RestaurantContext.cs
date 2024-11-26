using Microsoft.EntityFrameworkCore;
using Restaurant.Data.Entities;

namespace Restaurant.Data;
public class RestaurantContext : DbContext
{
    private readonly string connectionString;

    public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
    {

    }

    public RestaurantContext(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Entities.Action> Actions { get; set; }


}

