using Csharp_Lessons.OOP.TrafficLight.Enums;
using Csharp_Lessons.OOP.TrafficLight.Interfaces;

namespace Csharp_Lessons.OOP.TrafficLight.Implementation;

public class TrafficLight : ITrafficLight
{
    private TrafficLightState _trafficLightState;
    private TrafficLightState _previousState;

    public TrafficLight(TrafficLightState trafficLightState)
    {
        _trafficLightState = trafficLightState;
        _previousState = trafficLightState;
    }

    public void ShowLight() => Console.WriteLine($"The current light is: {_trafficLightState}");

    public void SwitchLight()
    {
        Task.Delay(1000).Wait(); 

        switch (_trafficLightState)
        {
            case TrafficLightState.Red:
                _previousState = _trafficLightState;
                _trafficLightState = TrafficLightState.Yellow;
                break;

            case TrafficLightState.Green:
                _previousState = _trafficLightState;
                _trafficLightState = TrafficLightState.Yellow;
                break;

            case TrafficLightState.Yellow:
                _trafficLightState = _previousState == TrafficLightState.Red
                    ? TrafficLightState.Green
                    : TrafficLightState.Red;
                break;
        }
    }

    public void SetLight(TrafficLightState light)
    {
        _previousState = _trafficLightState;
        _trafficLightState = light;
    }

    public TrafficLightState GetLight() => _trafficLightState;
}