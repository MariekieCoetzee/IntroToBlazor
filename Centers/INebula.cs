using IntroToBlazor.Models;

namespace IntroToBlazor.Centers;

public interface INebula
{
    List<Star> StarBirth(Galaxy galaxyScale);
    List<BlackHole> BlackHoleBirth(Galaxy galaxyScale);
}