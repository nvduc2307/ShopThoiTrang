using Microsoft.EntityFrameworkCore;

namespace ShopThoiTrang.BackEnd.Databases;
public class MainDbContext : DbContext {
    public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    //config dbset
    
}