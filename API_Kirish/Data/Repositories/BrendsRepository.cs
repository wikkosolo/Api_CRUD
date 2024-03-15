using API_Kirish.Data.Entities;
using API_Kirish.Data.Interfaces;
using GenericRepository;

namespace API_Kirish.Data.Repositories;

public class BrendsRepository(CarDbContext dbContext)
    : Repository<CarDbContext, Brends>(dbContext), IBrendsInterface
{
}
