using Microsoft.EntityFrameworkCore;

namespace CakeShop.Models;

public class CakeShopDbContext : DbContext
{
    public CakeShopDbContext(DbContextOptions<CakeShopDbContext> options)
        : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Pie> Pies { get; set; }

}
