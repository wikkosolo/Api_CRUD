using API_Kirish.BL.Dtos;
using API_Kirish.Data.Entities;
using API_Kirish.Data.Interfaces;

namespace API_Kirish.BL.Services;

public class BrendService(IBrendsInterface brendsInterface,
                          IFileService fileService)
    : IBrendService
{
    private readonly IBrendsInterface _brendsInterface = brendsInterface;
    private readonly IFileService _fileService = fileService;

    public void Add(AddBrendDto newBrend)
    {
        Brends brend = new()
        {
            Name = newBrend.Name,
            Image = _fileService.UploadImage(newBrend.file)
        };
        _brendsInterface.Add(brend);
    }

    public void Delete(int id)
    {
        var brend = _brendsInterface.GetById(id);
        if (brend != null)
        {
            _fileService.DeleteImage(brend.Image);
            _brendsInterface.Delete(brend);
        }
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
        var brendEntity = _brendsInterface.GetById(brend.Id);
        if (brend.file != null)
        {
            _fileService.DeleteImage(brendEntity.Image);
            brendEntity.Image = _fileService.UploadImage(brend.file);
        }
        brendEntity.Name = brend.Name;
        _brendsInterface.Update(brendEntity); 
    }

}
