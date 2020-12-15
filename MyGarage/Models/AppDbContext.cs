using Microsoft.EntityFrameworkCore;

namespace MyGarage.Models
{
   public class AppDbContext : DbContext
   {
      //   F i e l d s   &   P r o p e t r i e s

      public DbSet<User>    Users    { get; set; }
      public DbSet<Vehicle> Vehicles { get; set; }
      public DbSet<Repair>  Repairs  { get; set; }
      public DbSet<Upgrade> Upgrades { get; set; }

      //   C o n s t r u c t o r s

      public AppDbContext(DbContextOptions<AppDbContext> options)
         : base(options)
      {
      }

      //   M e t h o d s

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);

         modelBuilder.Entity<User>()
                     .HasIndex(u => u.Email)
                     .IsUnique();
      }

   }
}
