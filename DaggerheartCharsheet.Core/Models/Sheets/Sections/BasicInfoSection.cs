using DaggerheartCharsheet.Core.Enums;

namespace DaggerheartCharsheet.Core.Models.Sheets.Sections;

public sealed class BasicInfoSection : VersionedSection
{
    public AncestryType[] Ancestries { get; set; } = [];
    public SubclassType? Subclass { get; set; }
    public int Level { get; set; }
}