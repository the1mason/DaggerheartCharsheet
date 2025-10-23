namespace DaggerheartCharsheet.Core.Models.Sheets.Sections;

public sealed class DefenceSection : VersionedSection
{
    public int? ArmorMax { get; set; }
    public int ArmorMarked { get; set; }
    public int Evasion { get; set; }
}