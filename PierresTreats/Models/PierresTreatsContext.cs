using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierresTreats.Models
{
  public class PierresTreatsContext : IdentityDbContext<ApplicationUser>
  {
    public PierresTreatsContext(DbContextOptions<PierresTreatsContext> options) : base(options) 
    {
      Flavors = null!;
      FlavorTreats = null!;
      Treats = null!;
    }

    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<FlavorTreat> FlavorTreats { get; set; }
    public DbSet<Treat> Treats { get; set; }
  }
}
