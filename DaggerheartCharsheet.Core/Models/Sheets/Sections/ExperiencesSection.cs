namespace DaggerheartCharsheet.Core.Models.Sheets.Sections;

public sealed class ExperiencesSection : VersionedSection
{
    public KeyValuePair<string, int>[] Experiences { get; set; } = [];
}