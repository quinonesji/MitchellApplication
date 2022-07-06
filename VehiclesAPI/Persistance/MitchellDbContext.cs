using Microsoft.EntityFrameworkCore;
using VehiclesAPI.Core.Models;

namespace VehiclesAPI.Persistance
{
    public class MitchellDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }

        public MitchellDbContext(DbContextOptions<MitchellDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
