using DaggerheartCharsheet.Core.Enums;
using DaggerheartCharsheet.Core.Models.Cards;

namespace DaggerheartCharsheet.Core.Models.Sheets.Void;

public sealed class Brawler
{
    public Guid Id { get; set; }
    
    public GameVersionType GameVersion { get; set; }

    public CharacterClass CharacterClass { get; set; } = null!;
    
    public string? Name { get; set; }
    public string? Pronouns { get; set; }
    
    public int Level { get; set; }

    public AncestryType[] Ancestries { get; set; } = [];
    public CommunityType Community { get; set; }

    public static int EvasionBase => 11;
    public int Evasion { get; set; }
    
    // did not make it as a separate struct for now but might reconsider
    public int ArmorMax { get; set; }
    public int ArmorCrossed { get; set; }

    public int Agility { get; set; }
    public bool AgilityChecked { get; set; }
    
    public int Strength { get; set; }
    public bool StrengthChecked { get; set; }
    
    public int Finesse { get; set; }
    public bool FinesseChecked { get; set; }
    
    public int Instinct { get; set; }
    public bool InstinctChecked { get; set; }
    
    public int Presence { get; set; }
    public bool PresenceChecked { get; set; }
    
    public int Knowledge { get; set; }
    public bool KnowledgeChecked { get; set; }
    
    public int ThresholdMajor { get; set; }
    public int ThresholdSevere { get; set; }
    
    public HitPointsTracker HitPoints { get; set; } = new() { Points = 6, PointsCrossed = 0 };
    
    public StressTracker Stress { get; set; } = new() { Points = 6, PointsCrossed = 0 };
    
    public int HopePoints { get; set; }

    public (string Description, int Modifier)[] Experiences = [];
    
    public int WeaponsMastery { get; set; }
    public Weapon? WeaponPrimary { get; set; }
    public Weapon? WeaponSecondary { get; set; }
    
    public Armor? Armor { get; set; }
    
    public Gold Gold { get; set; } = new();
    
    public Dictionary<string, string> BackgroundResponses { get; set; } = [];
    public Dictionary<string, string> TiesResponses { get; set; } = [];
}

public record HitPointsTracker
{
    public int Points { get; set; } = 0;
    public int PointsCrossed { get; set; } = 0;
}

public record StressTracker
{
    public int Points { get; set; } = 0;
    public int PointsCrossed { get; set; } = 0;
}

public record Gold
{
    public int Handfuls { get; set; } = 0;
    public int Bags { get; set; } = 0;
    public bool HasChest { get; set; } = false;
}


public record Weapon
{
    public string? Name { get; set; }
    public string? AttributeAndRange { get; set; }
    public string? Damage { get; set; }
    public string? Description { get; set; }
    public bool LeftHand { get; set; }
    public bool RightHand { get; set; }
}

public record Armor
{
    public string? Name { get; set; }
    public string? Thresholds { get; set; }
    public string? Score { get; set; }
    public string? Description { get; set; }
}

public record Inventory
{
    public string? Stuff { get; set; }
    public Weapon[] Weapons { get; set; } = [];
}