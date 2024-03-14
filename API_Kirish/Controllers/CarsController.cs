using API_Kirish.BL.Dtos;
using API_Kirish.BL.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_Kirish.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarsController(ICarService carService)
    : ControllerBase
{
    private readonly ICarService _carService = carService;

    [HttpGet]
    public ActionResult Get()
    {
        var cars = _carService.GetAllCars();
        return Ok(cars);
    }
    [HttpGet("{id}")]
    public ActionResult GetById(int id)
    {
        var car = _carService.GetCarById(id);
        return Ok(car);
    }
    [HttpPost]
    public ActionResult Post(AddCarDto car)
    {
        _carService.Add(car);
        return Ok();
    }
    [HttpPut]
    public ActionResult Put(CarDto car)
    {
        _carService.Update(car);
        return Ok();
    }
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        _carService.Delete(id);
        return Ok();
    }
}
