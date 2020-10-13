# Blazor CRUD Entity Framework

In class DataContext modify the line optionsBuider.UseSqlServer
```ssh
	public class DataContext : DbContext
    {
        public DbSet<Dish> Dish { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Inser here your connection string");
        }
    }
```
