using IntroToBlazor.Models;

namespace IntroToBlazor.Centers;

public class Observation : IObservation
{
    public readonly ISatelite Service;

    public Observation(ISatelite service)
    {
        Service = service;
    }

    public async Task<Galaxy> GetUniverseScale()
    {
        var dimension = await Service.GetDimensions();

        return dimension;
    }

    public async Task<List<Star>> DetectNewDiscovery(List<Star> stars, Rocket? rocket)
    {
        stars = await GetStarPositions(stars);
        rocket = await GetRocketPosition();

        var discovery = stars?.FirstOrDefault(
            elem => (elem.Top <= rocket!.Bottom && elem.Bottom >= rocket.Top) &&
                    (elem.Left <= rocket.Right && elem.Right >= (rocket.Right - elem.Width))
        );

        if (discovery == null) return stars!;

        stars!.ForEach(
            x =>
            {
                if (x.Name != discovery.Name) return;
                x.Discovered = true;
                x.Animation = "discovered";
            }
        );

        return stars!;
    }

    private async Task<List<Star>> GetStarPositions(List<Star> stars)
    {
        if (stars[0].Bottom != 0 || stars[0].Height != 0) return stars;
        var starsPositions = await Service.GetStarsPositions();
        if (starsPositions != null && starsPositions.Any())
            stars = starsPositions;
        return stars;
    }

    private async Task<Rocket?> GetRocketPosition()
    {
        return await Service.GetRocketPosition();
    }
    public Task DetectBlackHoleCollision(List<BlackHole> blackHoles, Rocket? rocket)
    {
        throw new NotImplementedException();
    }
}