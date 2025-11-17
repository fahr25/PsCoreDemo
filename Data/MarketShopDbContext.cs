using Microsoft.EntityFrameworkCore;

using PsCoreDemo.Models;

namespace PsCoreDemo.Data;

public class MarketShopDbContext : DbContext
{
    // Constructor to pass options to the base DbContext class
    public MarketShopDbContext(DbContextOptions<MarketShopDbContext> options) : base(options)
    {
    }

    // Expose DbSet properties for each entity to be mapped to database tables
    // Makes it possible to query and save instances of these entities 
    public DbSet<Card> Cards { get; set; }
    public DbSet<Category> Categories { get; set; }

}
