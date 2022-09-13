using IntroToBlazor.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace IntroToBlazor.Centers;

public class Control : IControl
{
    private readonly ISatelite Service;

    public Control(ISatelite service)
    {
        Service = service;
    }

    public void MoveBlackHoles(List<BlackHole> blackHoles, Rocket? rocket)
    {
        foreach (var blackHole in blackHoles)
        {
            var top = blackHole.Top < rocket!.Top ? blackHole.Top + 7 : blackHole.Top - 7;
            var left = blackHole.Left > rocket.Left ? blackHole.Left - 7 : blackHole.Left + 7;
            blackHole.Top = top;
            blackHole.Left = left;
        }
    }

    public async Task<Rocket> MoveRocket(KeyboardEventArgs e, Rocket? rocket, Galaxy galaxyScale)
    {
        var rocketposition = await Service.GetRocketPosition();
        switch (e.Key)
        {
            case "ArrowUp":
                if ((rocketposition!.Top - 20) >= 0)
                {
                    rocket!.Top -= 20;
                    rocket.RocketDirection = Rocket.Direction.Up;
                }

                break;
            case "ArrowDown":
                if (rocketposition!.Bottom <= galaxyScale.Bottom)
                {
                    rocket!.Top += 20;
                    rocket.RocketDirection = Rocket.Direction.Down;
                }

                break;
            case "ArrowLeft":
                if (rocketposition!.Left - 20 >= 0)
                {
                    rocket!.Left -= 20;
                    rocket.RocketDirection = Rocket.Direction.Left;
                }

                break;
            case "ArrowRight":
                if (rocketposition!.Right <= galaxyScale.Right)
                {
                    rocket!.Left += 20;
                    rocket.RocketDirection = Rocket.Direction.Right;
                }

                break;
        }

        return rocket!;
    }

    public async Task SetFocus(ElementReference referenceToRocket)
    {
        await Service.SetFocus(referenceToRocket);
    }
}