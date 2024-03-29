﻿using API_Kirish.Data.Entities;
using API_Kirish.Data.Interfaces;
using GenericRepository;

namespace API_Kirish.Data.Repositories;

public class CarRepository(CarDbContext dbContext) : 
    Repository<CarDbContext, Car>(dbContext) , 
    ICarInterface
{
}
