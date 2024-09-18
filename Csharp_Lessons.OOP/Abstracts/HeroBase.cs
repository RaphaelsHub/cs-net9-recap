using Csharp_Lessons.OOP.Enums;
using Csharp_Lessons.OOP.Implementations;
using Csharp_Lessons.OOP.Interfaces;
using Csharp_Lessons.OOP.Models;

namespace Csharp_Lessons.OOP.Abstracts;

public abstract class HeroBase : IUltraDamage
{
    // Constants
    private const uint MaxLevel = 3;
    private const uint MaxHealth = 100;
    private const uint MaxAttackDamage = 50;

    // Auto-properties
    private uint CurrentLvl { get; set; } = 1;
    protected string? Type { get; private init; }
    


    // Properties
    private string? Name { get; set; }
    public uint Lvl { get; private set; }
    private int RequiredExperienceForNextLevel { get; set; }
    private uint Health { get; set; }
    private uint _armor;
    public uint Armor
    {
        get => _armor;
        private set
        {
            Health += value; 
            _armor = value;  
        }
    }
    public uint Damage { get; private set; }
    public float Speed { get; private set; }

    private SpeedType _speedType;
    public SpeedType SpeedType
    {
        get => _speedType;
        private set
        {
            _speedType = value;
            Speed = GetAgilityFromSpeedType(_speedType);
        }
    }

    //Action for level up event
    public event Action<uint>? LevelUpEvent;

    // Constructor
    protected HeroBase(Type type)
    {
        Type = type.Name;
        InitializeHero(CurrentLvl);
        LevelUpEvent += InitializeHero;
    }

    // Method to get agility from speed type
    private float GetAgilityFromSpeedType(SpeedType speedType) =>
        speedType switch
        {
            SpeedType.VeryLow => 0.5f,
            SpeedType.Low => 0.7f,
            SpeedType.Medium => 1.0f,
            SpeedType.High => 1.2f,
            SpeedType.VeryHigh => 1.5f,
            _ => 0.5f
        };

    // Initialize hero
    private void InitializeHero(uint lvl)
    {
        if (lvl > MaxLevel)
            throw new ArgumentException("Level is higher than the max allowed");

        HeroModel? model = LoadModel.GetHeroModel(lvl, Type ?? throw new ArgumentNullException(nameof(Type)));

        if (model != null)
        {
            Name = model.Name;
            CurrentLvl = model.Level;
            Lvl = model.Level;
            RequiredExperienceForNextLevel += (int)model.RequiredExperienceForNextLevel;
            Health = model.Health;
            Armor = model.Armor;
            Damage = model.Damage;
            SpeedType = model.SpeedType;
        }
    }

    public virtual void AttackUltra(HeroBase hero)
    {
        hero.GetDamage(MaxAttackDamage);
        Console.WriteLine($"{Name} attacks {hero.Name} with ultra damage! Health: {hero.Health}");
    }

    public virtual void GetDamage(uint damage)
    {
        Health -= Math.Min(damage, Health);
        Console.WriteLine($"{Name} received {damage} damage. Remaining health: {Health}");
    }
    
    public virtual void Heal(uint hp)
    {
        uint healthBefore = Health;
        Health = Math.Min(Health + hp, MaxHealth);
        Console.WriteLine($"Healing {hp} HP. Health before: {healthBefore}, current health: {Health}");
    }

    protected void AddExperience(int points)
    {
        RequiredExperienceForNextLevel -= points;

        if (RequiredExperienceForNextLevel <= 0)
        {
            CurrentLvl++;
            LevelUpEvent?.Invoke(CurrentLvl);
        }

        Console.WriteLine($"Experience for next level: {RequiredExperienceForNextLevel}");
    }

    // Абстрактные методы
    public abstract void Call();
    public abstract void Attack();
    public abstract void Move();
    public abstract void Die();
    public abstract void LevelUp();
}