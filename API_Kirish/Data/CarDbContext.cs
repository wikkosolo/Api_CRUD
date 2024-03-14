using API_Kirish.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_Kirish.Data;

public class CarDbContext(DbContextOptions<CarDbContext> options)
    : DbContext(options)
{
    public DbSet<Car> Cars { get; set; }

}
