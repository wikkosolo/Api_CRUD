namespace API_Kirish.Data.Entities;

public class Brends : BaseEntity
{
    public string Name { get; set; }
    public string Image { get; set; }
    public List<Car> Cars { get; set; } = new();
}
