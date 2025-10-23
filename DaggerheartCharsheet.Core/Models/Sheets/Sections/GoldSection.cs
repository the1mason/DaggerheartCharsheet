namespace DaggerheartCharsheet.Core.Models.Sheets.Sections;

public sealed class GoldSection : VersionedSection
{
    public int Handfuls { get; set; }
    public int Bags { get; set; }
    public bool HasChest { get; set; }
}