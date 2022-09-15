namespace IntroToBlazor.Models;

public class Rocket : AstronomicalObject
{
    public enum Status { Discovering , Lost, Win};

    public enum Direction
    {
        Up,
        Down,
        Right,
        Left
    };
    public Status RocketStatus { get; set; }
    public Direction RocketDirection { get; set; } = Direction.Up;
}