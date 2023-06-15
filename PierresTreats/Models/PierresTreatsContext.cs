using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PierresTreats.Models
{
    public class PierresTreatsContext : IdentityDbContext<ApplicationUser>
    {
        public PierresTreatsContext(DbContextOptions<PierresTreatsContext> options) : base(options) { }
    }
}
