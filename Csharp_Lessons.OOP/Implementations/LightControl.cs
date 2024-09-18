using Csharp_Lessons.OOP.Enums;

namespace Csharp_Lessons.OOP.Implementations;

public class LightControl(TrafficLightsType light)
{
    public void SwitchLight()
    {
        light = (light == TrafficLightsType.Red) ? TrafficLightsType.Green : (TrafficLightsType)(((int)light + 1) % 3);
    }

    public TrafficLightsType GetLight()
    {
        return light;
    }
}