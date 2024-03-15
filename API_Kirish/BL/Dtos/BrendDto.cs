using API_Kirish.Data.Entities;

namespace API_Kirish.BL.Dtos;

public class BrendDto : AddBrendDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Image { get; set; }
}
