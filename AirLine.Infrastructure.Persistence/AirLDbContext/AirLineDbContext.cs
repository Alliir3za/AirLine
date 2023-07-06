using Microsoft.EntityFrameworkCore;

namespace AirLine.Infrastructure.Persistence.AirLDbContext;

public class AirLineDbContext : DbContext
{
    public AirLineDbContext()
    {
    }
    public AirLineDbContext(DbContextOptions<AirLineDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=.;database=AirL;trusted_connection=true;");
    }
}
