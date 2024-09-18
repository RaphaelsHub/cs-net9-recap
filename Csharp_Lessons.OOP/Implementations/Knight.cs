using Csharp_Lessons.OOP.Abstracts;

namespace Csharp_Lessons.OOP.Implementations;

public class Knight() : HeroBase(typeof(Knight))
{
    public override void Call()
    {
        Console.WriteLine("Knight is calling!");
    }

    public override void Attack()
    {
        Console.WriteLine("Knight is attacking!");
    }

    public override void Move()
    {
        Console.WriteLine("Knight is moving!");
    }

    public override void Die()
    {
        Console.WriteLine("Knight is dying!");
    }

    public override void LevelUp()
    {
        Console.WriteLine("Knight is leveling up!");
    }

    public override void AttackUltra(HeroBase hero)
    {
        Console.WriteLine("Knight is attacking with ultra damage!");
        base.AttackUltra(hero);
        
    }
}