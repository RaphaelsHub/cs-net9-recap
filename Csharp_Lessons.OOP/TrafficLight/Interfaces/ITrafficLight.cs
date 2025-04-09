using Csharp_Lessons.OOP.TrafficLight.Enums;

namespace Csharp_Lessons.OOP.TrafficLight.Interfaces;

public interface ITrafficLight
{
    void ShowLight();
    void SwitchLight();
    void SetLight(TrafficLightState light);
    TrafficLightState GetLight();
}