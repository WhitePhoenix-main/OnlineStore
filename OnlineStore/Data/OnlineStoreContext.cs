using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineStore;

namespace OnlineStore;

public class OnlineStoreContext : IdentityDbContext<SiteUsers>
{
    public OnlineStoreContext(DbContextOptions<OnlineStoreContext> options)
        : base(options)
    {
    }
    public DbSet<ProductRecord> Product { get; set; }
}