using API_Kirish.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_Kirish.Data
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brends> Brends { get; set; }
    }
}
