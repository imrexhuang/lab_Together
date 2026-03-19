namespace Together.Domain.Entity;

public class Event
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; } = null;
    public string? Coordinator { get; set; } = null;
    public string? Place { get; set; } = null;
    public float Lat { get; set; }
    public float Lng { get; set; }
    public int Fee { get; set; }
}