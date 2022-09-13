using IntroToBlazor.Models;
using Microsoft.AspNetCore.Components;

public interface ISatelite
{
    Task<List<Star>?> GetStarsPositions();

    Task<List<BlackHole>?> GetLitterPositions();

    Task<Rocket?> GetRocketPosition();

    Task<Galaxy> GetDimensions();
    Task SetFocus(ElementReference referenceToRocket);
}