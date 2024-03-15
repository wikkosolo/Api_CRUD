using API_Kirish.BL.Dtos;
using API_Kirish.Data.Entities;
using API_Kirish.Data.Interfaces;

namespace API_Kirish.BL.Services;

public class BrendService(IBrendsInterface brendsInterface)
    : IBrendService
{
    private readonly IBrendsInterface _brendsInterface = brendsInterface;

    public void Add(AddBrendDto newBrend)
    {
        Brends brend = new()
        {
            Name = newBrend.Name,
            Image = newBrend.Image
        };
        _brendsInterface.Add(brend);
    }

    public void Delete(int id)
    {
        var brend = _brendsInterface.GetById(id);
        _brendsInterface.Delete(brend);
    }

    public List<BrendDto> GetAll()
    {
        var brends = _brendsInterface.GetAll();
        var dtos = brends.Select(b => new BrendDto
        {
            Id = b.Id,
            Name = b.Name,
            Image = b.Image
        }).ToList();
        return dtos;
    }

    public BrendDto GetById(int id)
    {
        var brend = _brendsInterface.GetById(id);
        var dto = new BrendDto
        {
            Id = brend.Id,
            Name = brend.Name,
            Image = brend.Image
        };
        return dto;
    }

    public void Update(BrendDto brend)
    {
        Brends brendEntity = new()
        {
            Id = brend.Id,
            Name = brend.Name,
            Image = brend.Image
        };
        _brendsInterface.Update(brendEntity);
    }
}
