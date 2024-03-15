using API_Kirish.BL.Dtos;
using API_Kirish.BL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Kirish.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrendsController(IBrendService brendService)
    : ControllerBase
{
    private readonly IBrendService _brendService = brendService;
    [HttpGet]
    public ActionResult Get()
    {
        var brends = _brendService.GetAll();
        return Ok(brends);
    }
    [HttpGet("{id}")]
    public ActionResult GetById(int id)
    {
        var brend = _brendService.GetById(id);
        return Ok(brend);
    }
    [HttpPost]
    public ActionResult Post(AddBrendDto brend)
    {
        _brendService.Add(brend);
        return Ok();
    }
    [HttpPut]
    public ActionResult Put(BrendDto brend)
    {
        _brendService.Update(brend);
        return Ok();
    }
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        _brendService.Delete(id);
        return Ok();
    }

}
