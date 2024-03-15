using API_Kirish.BL.Dtos;
using API_Kirish.Data.Entities;
using API_Kirish.Data.Interfaces;

namespace API_Kirish.BL.Services
{
    public class CarService : ICarService
    {
        private readonly ICarInterface _carInterface;

        public CarService(ICarInterface carInterface)
        {
            _carInterface = carInterface;
        }

        public void Add(AddCarDto newCar)
        {
            Car car = new()
            {
                Model = newCar.Model,
                Year = newCar.Year,
                Color = newCar.Color,
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
                Id = c.Id,
                Model = c.Model,
                Year = c.Year,
                Color = c.Color,
                Price = c.Price
            }).ToList();
            return dtos;
        }

        public CarDto GetCarById(int id)
        {
            var car = _carInterface.GetById(id);
            var dto = new CarDto
            {
                Id = car.Id,
                Model = car.Model,
                Year = car.Year,
                Color = car.Color,
                Price = car.Price
            };
            return dto;
        }

        public void Update(CarDto dto)
        {
            var car = _carInterface.GetById(dto.Id);
            car.Model = dto.Model;
            car.Year = dto.Year;
            car.Color = dto.Color;
            car.Price = dto.Price;
            _carInterface.Update(car);
        }
    }
}
