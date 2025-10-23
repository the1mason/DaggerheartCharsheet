namespace DaggerheartCharsheet.Core.Models.Sheets.Sections;

public sealed class BackgroundsAndConnectionsSection : VersionedSection
{
    public Dictionary<string, string> Background { get; set; } = [];
    public Dictionary<string, string> Connections { get; set; } = [];
}