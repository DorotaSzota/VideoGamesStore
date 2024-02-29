using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using VideoGamesStore.Models;

namespace VideoGamesStore.Data;

public class VgsDbContext : DbContext
{
    public VgsDbContext(DbContextOptions<VgsDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Action", DisplayOrder = 1 },
            new Category { CategoryId = 2, Name = "RPG", DisplayOrder = 2 },
            new Category { CategoryId = 3, Name = "Action RPG", DisplayOrder = 3 },
            new Category { CategoryId = 4, Name = "Fighting", DisplayOrder = 4 },
            new Category { CategoryId = 5, Name = "Adventure", DisplayOrder = 5 },
            new Category { CategoryId = 6, Name = "Strategy", DisplayOrder = 6 },
            new Category { CategoryId = 7, Name = "Sports", DisplayOrder = 7 },
            new Category { CategoryId = 8, Name = "Racing", DisplayOrder = 8 },
            new Category { CategoryId = 9, Name = "Simulation", DisplayOrder = 9 },
            new Category { CategoryId = 10, Name = "Indie", DisplayOrder = 10 }
        );
    }
}