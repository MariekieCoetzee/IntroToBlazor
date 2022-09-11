using IntroToBlazor.Models;
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
}