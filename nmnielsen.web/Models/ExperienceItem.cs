namespace nmnielsen.web.Models;
public class ExperienceItem
{
    public required string Company { get; set; }
    public string? Title { get; set; }
    public string? Location { get; set; }
    public string? Period { get; set; }
    public required List<string> Bullets { get; set; }
    public bool IsTopBorder { get; set; }
}