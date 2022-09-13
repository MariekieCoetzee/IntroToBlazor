using IntroToBlazor.Models;

namespace IntroToBlazor.Centers;

public interface IObservation
{
    Task<Galaxy> GetUniverseScale();
    Task<List<Star>> DetectNewDiscovery(List<Star> stars, Rocket? rocket);

    Task DetectBlackHoleCollision(List<BlackHole> blackHoles, Rocket? rocket);

    void DiscoveryStatus(Rocket rocket, List<Star> stars);
}