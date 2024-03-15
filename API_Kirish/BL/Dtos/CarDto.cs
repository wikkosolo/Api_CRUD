namespace API_Kirish.BL.Dtos;

public class CarDto : AddCarDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int BrendId { get; set; }
}
