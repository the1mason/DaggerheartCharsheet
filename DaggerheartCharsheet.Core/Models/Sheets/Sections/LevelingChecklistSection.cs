namespace DaggerheartCharsheet.Core.Models.Sheets.Sections;

public sealed class LevelingChecklistSection : VersionedSection
{
    public LevelingCheckListItem[] Level { get; set; } = [];
}

public sealed class LevelingCheckListItem
{
    public string Key { get; set; } = string.Empty;
    public int Checks { get; set; }
    public int Checked { get; set; }
}