using IntroToBlazor.Models;

namespace IntroToBlazor.Centers;

public class Nebula : INebula
{
    public List<Star> StarBirth(Galaxy galaxyScale)
    {
        Random rnd = new Random();
        var flexWidth = (int)galaxyScale.Width / 12;
        var flexHeight = (int)galaxyScale.Height / 12;
        return new List<Star>()
        {
            new Star()
            {
                Image = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/github/github-original.svg",
                Top = rnd.Next(8, flexHeight * 2),
                Left = rnd.Next(8, flexWidth * 2),
                Name = "github",
                IconType = "star devicon-github-original-wordmark",
                Color = "white"
            },
            new Star()
            {
                Image = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg",
                Top = rnd.Next(8, flexHeight * 6),
                Left = rnd.Next(8, flexWidth * 6),
                Name = "csharp",
                IconType = "star devicon-csharp-plain-wordmark",
                Color = "white",
            },
            new Star()
            {
                Image = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/azure/azure-original-wordmark.svg",
                Top = rnd.Next(flexHeight * 2, flexHeight * 5),
                Left = rnd.Next(flexWidth * 2, flexWidth * 5),
                Name = "azure",
                IconType = "star devicon-azure-plain-wordmark",
                Color = "white",
            },
            new Star()
            {
                Image = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg",
                Top = rnd.Next(flexHeight * 7, flexHeight * 10),
                Left = rnd.Next(flexWidth * 9, flexWidth * 10),
                Name = "dotnetcore",
                IconType = "star devicon-dotnetcore-plain",
                Color = "white",
            },
            new Star()
            {
                Image = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dot-net/dot-net-plain-wordmark.svg",
                Top = rnd.Next(flexHeight * 8, flexHeight * 11),
                Left = rnd.Next(flexWidth * 2, flexWidth * 5),
                Name = "dot-net",
                IconType = "star devicon-dot-net-plain-wordmark",
                Color = "white",
            },
            new Star()
            {
                Image = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/css3/css3-original.svg",
                Top = rnd.Next(flexHeight * 2, flexHeight * 5),
                Left = rnd.Next(flexWidth * 8, flexWidth * 11),
                Name = "css3",
                IconType = "star devicon-css3-plain-wordmark",
                Color = "white",
            },
            new Star()
            {
                Image = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/javascript/javascript-original.svg",
                Top = rnd.Next(flexHeight * 10, flexHeight * 11),
                Left = rnd.Next(flexWidth * 7, flexWidth * 9),
                Name = "javascript",
                IconType = "star devicon-javascript-plain",
                Color = "white",
            },
            new Star()
            {
                Image = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/html5/html5-original-wordmark.svg",
                Top = rnd.Next(flexHeight, flexHeight * 3),
                Left = rnd.Next(flexWidth, flexWidth * 3),
                Name = "html5",
                IconType = "star devicon-html5-plain-wordmark",
                Color = "white",
            },
            new Star()
            {
                Image = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/android/android-plain-wordmark.svg",
                Top = rnd.Next(flexHeight, flexHeight * 9),
                Left = rnd.Next(flexWidth * 7, flexWidth * 9),
                Name = "android",
                IconType = "star devicon-android-plain-wordmark",
                Color = "white",
            },
            new Star()
            {
                Image = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/apple/apple-original.svg",
                Top = rnd.Next(flexHeight, flexHeight * 5),
                Left = rnd.Next(flexWidth, flexWidth * 5),
                Name = "apple",
                IconType = "star devicon-apple-original",
                Color = "white"
            },
            new Star()
            {
                Image =
                    "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/visualstudio/visualstudio-plain-wordmark.svg",
                Top = rnd.Next(flexHeight, flexHeight * 5),
                Left = rnd.Next(flexWidth * 7, flexWidth * 11),
                Name = "visualstudio",
                IconType = "star devicon-visualstudio-plain-wordmark",
                Color = "white",
            },
            new Star()
            {
                Image = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/jetbrains/jetbrains-original.svg",
                Top = rnd.Next(flexHeight * 10, flexHeight * 11),
                Left = rnd.Next(flexWidth * 2, flexWidth * 6),
                Name = "jetbrains",
                IconType = "star devicon-jetbrains-plain",
                Color = "white",
            }
        };
    }

    public List<BlackHole> BlackHoleBirth(Galaxy galaxyScale)
    {
        return new List<BlackHole>()
        {
            new BlackHole
            {
                Top = galaxyScale.Top * 4,
                Left = galaxyScale.Left * 4,
                Name = "hourglass",
                IconType = "fa-regular fa-hourglass-half  fa-spin",
                Animation = "--fa-animation-duration: 2s",
                Color = "darksalmon"
            },
            new BlackHole
            {
                Top = galaxyScale.Height - 60,
                Left = galaxyScale.Left * 4,
                Name = "cough",
                IconType = "fa-solid fa-head-side-cough  fa-beat",
                Animation = "--fa-animation-duration: 2s",
                Color = "darksalmon"
            },
            new BlackHole
            {
                Top = galaxyScale.Top * 4,
                Left = galaxyScale.Width - 60,
                Name = "ghost",
                IconType = "fa-solid fa-ghost fa-beat",
                Animation = "--fa-animation-duration: 2s",
                Color = "darksalmon"
            },
            new BlackHole
            {
                Top = galaxyScale.Height - 60,
                Left = galaxyScale.Width - 60,
                Name = "virus",
                IconType = "fa-solid fa-virus-covid fa-spin",
                Color = "darksalmon"
            }
        };
    }
}