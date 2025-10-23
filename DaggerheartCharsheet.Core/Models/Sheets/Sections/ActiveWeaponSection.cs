namespace DaggerheartCharsheet.Core.Models.Sheets.Sections;

public sealed class ActiveWeaponsSection : VersionedSection
{
    public int Mastery { get; set; }
    public bool LeftHand { get; set; }
    public bool RightHand { get; set; }
    public ActiveWeapon? WeaponPrimary { get; set; }
    public ActiveWeapon? WeaponSecondary { get; set; }
}

public sealed class ActiveWeapon
{
    public string? Name { get; set; }
    public string? RangeAndAttribute { get; set; }
    public string? DamageDiceAndKind { get; set; }
    public string? Description { get; set; }
}