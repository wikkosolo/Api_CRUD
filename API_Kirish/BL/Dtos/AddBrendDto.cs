namespace API_Kirish.BL.Dtos;

public class AddBrendDto
{
    public string Name { get; set; } = string.Empty;
    public IFormFile? file { get; set; }
}
