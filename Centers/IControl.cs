using IntroToBlazor.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace IntroToBlazor.Centers;

public interface IControl
{
    void MoveBlackHoles(List<BlackHole> blackHoles, Rocket? rocket);

    Task<Rocket> MoveRocket(KeyboardEventArgs e, Rocket? rocket,
                            Galaxy galaxyScale);

    Task SetFocus(ElementReference referenceToRocket);
}