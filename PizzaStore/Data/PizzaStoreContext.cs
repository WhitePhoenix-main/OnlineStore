using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PizzaStore;

namespace PizzaStore;

public class PizzaStoreContext : IdentityDbContext<SiteUsers>
{
    public PizzaStoreContext(DbContextOptions<PizzaStoreContext> options)
        : base(options)
    {
    }
    public DbSet<ProductRecord> Product { get; set; } = null!;
}