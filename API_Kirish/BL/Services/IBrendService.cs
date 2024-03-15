using API_Kirish.BL.Dtos;

namespace API_Kirish.BL.Services;

public interface IBrendService
{
    List<BrendDto> GetAll();
    BrendDto GetById(int id);
    void Add(AddBrendDto brend);
    void Update(BrendDto brend);
    void Delete(int id);
}
