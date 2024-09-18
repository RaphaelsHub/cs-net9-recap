using Csharp_Lessons.OOP.Abstracts;

namespace Csharp_Lessons.OOP.Implementations;

public class Track : CarBase
{
    private readonly uint _speed;
    private readonly uint _acceleration;
    
    public Track(uint speed, uint acceleration) : base(nameof(Track))
    {
        _speed = speed;
        _acceleration = acceleration;
    }

    public override void Move()
    {
        Console.WriteLine("Track is moving");
    }

    public override void Stop()
    {
        Console.WriteLine("Track is stopping");
    }

    public override void RotateWheels()
    {
        Console.WriteLine("Track is rotating wheels");
    }

    public override void StartEngine()
    {
        Console.WriteLine("Track engine is starting");
    }
    
    public new void OpenDoor()
    {
        Console.WriteLine("Track door is opening");
    }
    
    public void ShowSpeed()
    {
        Console.WriteLine($"Track speed: {_speed}");
    }
}