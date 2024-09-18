namespace Csharp_Lessons.OOP.Abstracts;

public abstract class CarBase
{
    private string _nameCar;

    protected CarBase(string nameCar)
    {
        _nameCar = nameCar;
    }

    public abstract void Move();
    public abstract void Stop();
    public abstract void RotateWheels();

    public void ShowNameCar()
    {
        Console.WriteLine(_nameCar);
    }
    
    public virtual void StartEngine()
    {
        Console.WriteLine("Car base Engine is starting");
    }
    
    public void OpenDoor()
    {
        Console.WriteLine("Car base Door is opening");
    }
}