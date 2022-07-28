using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineStore;

namespace OnlineStore.Data;

public class OnlineStoreDbContext : IdentityDbContext
{
    public OnlineStoreDbContext(DbContextOptions<OnlineStoreDbContext> options)
        : base(options)
    {
    }
    public DbSet<ProductRecord> Product { get; set; }
}