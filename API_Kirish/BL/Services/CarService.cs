using API_Kirish.BL.Dtos;
using API_Kirish.Data.Entities;
using API_Kirish.Data.Repositories;

namespace API_Kirish.BL.Services;

public class CarService (ICarInterface carInterface)
    : ICarService
{
    private readonly ICarInterface _carInterface = carInterface;

    public void Add(AddCarDto newCar)
    {
        Car car = new()
        {
            Model = newCar.Model,
            Year = newCar.Year,
            Color = newCar.Color,
            Image = newCar.Image,
            Price = newCar.Price
        };
        _carInterface.Add(car);
    }

    public void Delete(int id)
    {
        var car = _carInterface.GetById(id);
        _carInterface.Delete(car);
    }

    public List<CarDto> GetAllCars()
    {
        var cars = _carInterface.GetAll();
        var dtos = cars.Select(c => new CarDto
        {
            ID = c.ID,
            Model = c.Model,
            Year = c.Year,
            Color = c.Color,
            Image = c.Image,
            Price = c.Price
        }).ToList();
        return dtos;
    }

    public CarDto GetCarById(int id)
    {
        var car = _carInterface.GetById(id);
        var dto = new CarDto
        {
            ID = car.ID,
            Model = car.Model,
            Year = car.Year,
            Color = car.Color,
            Image = car.Image,
            Price = car.Price
        };
        return dto;
    }

    public void Update(CarDto dto)
    {
        var car = _carInterface.GetById(dto.ID);
        car.Model = dto.Model;
        car.Year = dto.Year;
        car.Color = dto.Color;
        car.Image = dto.Image;
        car.Price = dto.Price;
        _carInterface.Update(car); 
    }
}
