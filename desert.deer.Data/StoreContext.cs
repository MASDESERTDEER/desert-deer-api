using desert.deer.Domain.Catalog;
using desert.deer.Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace desert.deer.Data{
public class StoreContext: DbContext {
    public StoreContext(DbContextOptions<StoreContext> options): base(options){ }
    public DbSet<Item> Items {get; set;}
    public DbSet<Order> Orders {get; set;}
    

    protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);   

            builder.Entity<Item>()
                .HasMany(i => i.Ratings)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);  
        }





    }


}

