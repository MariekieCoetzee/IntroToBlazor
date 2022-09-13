namespace IntroToBlazor.Models;

public class Star : AstronomicalObject
{
    public string Image { get; set; } = null!;
    public Boolean Discovered { get; set; }
}