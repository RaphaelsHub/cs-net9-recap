using Csharp_Lessons.OOP.Models;
using Newtonsoft.Json;

namespace Csharp_Lessons.OOP.Implementations;

public static class LoadModel
{
    public static HeroModel? GetHeroModel(uint lvl, string heroType)
    {
        var json = File.ReadAllText(@"D:\\Csharp_Lessons\\Csharp_Lessons.OOP\\JsonFiles\\HeroesData.json");

        HeroesData? heroesData = JsonConvert.DeserializeObject<HeroesData>(json);

        if (heroesData == null) return null;

        LevelsData? levelsData = heroType switch
        {
            "Archer" => heroesData.Archer,
            "Knight" => heroesData.Knight,
            _ => null
        };

        if (levelsData == null) return null;

        var data = levelsData.Levels?.FirstOrDefault(x => x.Level == lvl);

        data ??= levelsData.Levels?.FirstOrDefault(x => x.Level == 1);

        return new HeroModel
        {
            Name = heroType + data!.Level,
            Level = data!.Level,
            RequiredExperienceForNextLevel = data.RequiredExperienceForNextLevel,
            Health = data.Health,
            Armor = data.Armor,
            Damage = data.Damage,
            SpeedType = data.SpeedType
        };
    }
}