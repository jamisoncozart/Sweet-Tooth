using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SweetTooth.Models
{
  public class SweetToothContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Sweet> Sweets { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<SweetFlavor> SweetFlavor { get; set; }
    public SweetToothContext(DbContextOptions options) : base(options) { }
  }
}