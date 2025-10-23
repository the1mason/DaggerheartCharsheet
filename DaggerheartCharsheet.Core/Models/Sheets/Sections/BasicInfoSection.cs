using DaggerheartCharsheet.Core.Enums;

namespace DaggerheartCharsheet.Core.Models.Sheets.Sections;

public sealed class BasicInfoSection : VersionedSection
{
    // each ancestry is version-dependent and thus should have version attached.
    // A sheet may have ancestry from a different game version and that should be localized properly.
    // I will bring back ancestry card class later
    public AncestryType[] Ancestries { get; set; } = [];
    // similar to ancestries, classes are version-dependent
    public SubclassType? Subclass { get; set; }
    public int Level { get; set; }
}