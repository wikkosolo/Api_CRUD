using API_Kirish.BL.Dtos;

namespace API_Kirish.BL.Services;

public interface ICarService
{
    List<CarDto> GetAllCars();
    CarDto GetCarById(int id);
    void Add(AddCarDto car);
    void Update(CarDto car);
    void Delete(int id);
}
