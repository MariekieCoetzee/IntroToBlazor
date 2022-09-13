using IntroToBlazor.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace IntroToBlazor.Services;

public class Satelite : ISatelite
{
    private readonly IJSRuntime _js;

    public Satelite(IJSRuntime js)
    {
        _js = js;
    }

    public async Task<Galaxy> GetDimensions()
    {
        return await _js.InvokeAsync<Galaxy>("getDimensions");
    }

    public async Task<Rocket?> GetRocketPosition()
    {
        return await _js.InvokeAsync<Rocket>("getRocketPosition");
    }

    public async Task<List<Star>?> GetStarsPositions()
    {
        return await _js.InvokeAsync<List<Star>>("getStarsPositions");
    }

    public async Task<List<BlackHole>?> GetLitterPositions()
    {
        return await _js.InvokeAsync<List<BlackHole>>("getLitterPositions");
    }

    public async Task SetFocus(ElementReference referenceToRocket)
    {
        await _js.InvokeVoidAsync("setFocus", referenceToRocket);
    }
}