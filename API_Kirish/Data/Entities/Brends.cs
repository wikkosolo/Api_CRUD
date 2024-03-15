namespace API_Kirish.Data.Entities;

public class Brends : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Image { get; set; } = null!;
    public List<Car> Cars { get; set; } = new();
}
