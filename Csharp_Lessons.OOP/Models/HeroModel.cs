using Csharp_Lessons.OOP.Enums;

namespace Csharp_Lessons.OOP.Models;

public class HeroModel
{
    public string? Name { get; init; }
    public uint Level { get; init; }
    public uint RequiredExperienceForNextLevel { get; init; }
    public uint Health { get; init; }
    public uint Armor { get; init; }
    public uint Damage { get; init; }
    public SpeedType SpeedType { get; init; }
}