using Microsoft.EntityFrameworkCore;

namespace VideoGamesStore.Data;

public class VgsDbContext : DbContext
{
    public VgsDbContext(DbContextOptions<VgsDbContext> options) : base(options)
    {
    }
}