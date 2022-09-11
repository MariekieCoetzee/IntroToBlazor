using IntroToBlazor.Models;

namespace IntroToBlazor.Centers;

public interface IObservation
{
    Task<Galaxy> GetUniverseScale();
}