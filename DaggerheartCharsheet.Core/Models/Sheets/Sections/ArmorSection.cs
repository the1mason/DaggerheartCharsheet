namespace DaggerheartCharsheet.Core.Models.Sheets.Sections;

public sealed class ArmorSection : VersionedSection
{
    public string? Name { get; set; }
    public string? BaseThresholds { get; set; }
    public string? BaseScore { get; set; }
    public string? Description { get; set; }
}