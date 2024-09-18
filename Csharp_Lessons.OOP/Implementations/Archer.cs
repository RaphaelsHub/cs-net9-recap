using Csharp_Lessons.OOP.Abstracts;

namespace Csharp_Lessons.OOP.Implementations;

public class Archer() : HeroBase(typeof(Archer))
{
    // Конструктор

    public override void Call()
    {
        Console.WriteLine("Archer is calling!");
    }

    public override void Attack()
    {
        Console.WriteLine("Archer is attacking!");
        AddExperience(600);
    }

    public override void Move()
    {
        Console.WriteLine("Archer is moving!");
    }

    public override void Die()
    {
        Console.WriteLine("Archer is dying!");
    }

    public override void LevelUp()
    {
        Console.WriteLine("Archer leveled up!");
    }

    public override void AttackUltra(HeroBase hero)
    {
        Console.WriteLine("Archer is using ultra attack!");
        base.AttackUltra(hero);
    }
}