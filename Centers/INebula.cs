using IntroToBlazor.Models;

namespace IntroToBlazor.Centers;

public interface INebula
{
    List<Star> StarBirth();
    List<BlackHole> BlackHoleBirth();
}