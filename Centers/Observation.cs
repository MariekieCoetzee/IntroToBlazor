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
}