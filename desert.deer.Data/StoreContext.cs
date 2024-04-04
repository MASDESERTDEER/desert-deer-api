﻿using desert.deer.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace desert.deer.Data{
public class StoreContext: DbContext {
    public StoreContext(DbContextOptions<StoreContext> options): base(options){ }
    public DbSet<Item> Items {get; set;}
    }
}
