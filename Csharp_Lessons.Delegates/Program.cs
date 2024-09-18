namespace Csharp_Lessons.Delegates;

class Program
{
    static void Main(string[] args)
    {
        DelegateTest();
    }
    
    private static void DelegateTest()
    {
        TeslaCar car = new TeslaCar(HandleOnCheckSpeedUp, HandleOnCheckSpeedDown);

        // car.SubscribeOnSpeedUp(HandleOnCheckSpeedUp);
        // car.SubscribeOnSpeedDown(HandleOnCheckSpeedDown);
        
        car.SpeedUp += HandleOnCheckSpeedUp;
        car.SpeedDown += HandleOnCheckSpeedDown;
        
        
        for (int i = 0; i < 10; i++)
        {
            car.Accelerate();
        }
    }

    private static void HandleOnCheckSpeedUp(object? obj, float speed)
    {
        Console.WriteLine("Calling speed up!");
        var car = (TeslaCar)obj!;
        car.StartEngine();
    }

    private static void HandleOnCheckSpeedDown(object? obj, float speed)
    {
        Console.WriteLine("Calling speed down!");
        var car = (TeslaCar)obj!;
        car.Stop(speed);
    }
}