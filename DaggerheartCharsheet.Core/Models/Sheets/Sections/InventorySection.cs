namespace DaggerheartCharsheet.Core.Models.Sheets.Sections;

public sealed class InventorySection : VersionedSection
{
    public string? Stuff { get; set; }
    public StoredWeapon[] Weapons { get; set; } = [];
}

public class StoredWeapon
{
    public string? Name { get; set; }
    public string? RangeAndAttribute { get; set; }
    public string? DamageDiceAndKind { get; set; }
    public string? Description { get; set; }
    public bool LeftHand { get; set; }
    public bool RightHand { get; set; }
    public bool Main { get; set; }
    public bool OffHand { get; set; }
}