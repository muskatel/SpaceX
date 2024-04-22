namespace SpaceX;

public class Launch
{
    public String rocket { get; set; }
    public String name { get; set; }
    public DateTime date_utc { get; set; }
    public bool? success { get; set; }
    public string? details { get; set; } 
}