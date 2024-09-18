using System.Diagnostics;
using System.Drawing;
using Csharp_Lessons.OOP.Abstracts;
using Csharp_Lessons.OOP.Enums;
using Csharp_Lessons.OOP.Implementations;
using Csharp_Lessons.OOP.Interfaces;
using Csharp_Lessons.OOP.Interfaces.Extensions;

namespace Csharp_Lessons.OOP;

class Program
{
    static void Main()
    {
        //PolymorphicTest();
        //SwitchLightTest();
        //IsAsTest();
        //AbstractsTest();
        //HeroBaseTest();
    }
    
    private static void HeroBaseTest()
    {
        HeroBase hero = new Archer();
        hero.Attack();
        hero.Attack();
        hero.Attack();
        hero.Call();
        hero.Die();
        hero.LevelUp();
        hero.Move();
        hero.AttackUltra(hero);
        hero.GetDamage(20);
    }
    
    private static void AbstractsTest()
    {
        //1 способ
        CarBase car = new Track(100, 200);
        car.StartEngine();
        car.Move();
        car.RotateWheels();
        car.Stop();
        car.ShowNameCar();
        car.OpenDoor();

        //2 способ
        Track track = new(100, 200);
        track.StartEngine();
        track.Move();
        track.RotateWheels();
        track.Stop();
        track.ShowNameCar();
        track.OpenDoor();
        track.ShowSpeed();
    }

    private static void PolymorphicTest()
    {
        Weapon weapon = new Weapon();
        weapon.Print(); //Hello Daddy, I am a weapon

        
        Gun gun = new Gun();
        gun.Print(); //Hello Daddy, I am A gun
        
        Weapon weapon1 = new Gun();
        weapon1.Print(); //Hello Daddy, I am a weapon
    }

    private static void SwitchLightTest()
    {
        LightControl control = new LightControl(TrafficLightsType.Red);
        control.SwitchLight();
        Debug.Assert(control.GetLight() == TrafficLightsType.Green);
        control.SwitchLight();
        Debug.Assert(control.GetLight() == TrafficLightsType.Yellow);
        control.SwitchLight();
        Debug.Assert(control.GetLight() == TrafficLightsType.Red);
    }
    
    private static void IsAsTest()
    {
        //Is - проверяет является ли объект экземпляром класса
        //As - приводит объект к типу
        IBook book = new BookControl();
        book.ReadABook(10);
        book.TakeABook(10);
        book.WriteABook("Hello");

        //Мы можем привет Ibook к IBookControl, потому что IBookControl наследует IBook
        (book as IBookControl)?.ReadABook(12);
        (book as IBookControl)?.TakeABook(10);
        (book as IBookControl)?.WriteABook("Hello");
        (book as IBookControl)?.AddABookToLibrary(11);
        (book as IBookControl)?.AddRangeOfBooks(1, 2, 3, 4, 5);
        

        IBookControl control = new BookControl();
        control.ReadABook(1);
        control.TakeABook(1);
        control.WriteABook("Hello");
        control.AddRangeOfBooks(1,2,3,4,5);
        control.AddABookToLibrary(1);
        
        
        (control as IBook).ReadABook(10);
        (control as IBook).TakeABook(10);
        (control as IBook).WriteABook("Hello");
    }
}