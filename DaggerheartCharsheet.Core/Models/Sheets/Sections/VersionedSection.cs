namespace DaggerheartCharsheet.Core.Models.Sheets.Sections;

public abstract class VersionedSection
{
    public DateTimeOffset Version { get; set; }
}