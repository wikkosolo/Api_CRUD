namespace API_Kirish.Data.Entities;

public class Car : BaseEntity
{
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
    public int BrendId { get; set; }
    public Brends Brends { get; set; } = null!;
}
