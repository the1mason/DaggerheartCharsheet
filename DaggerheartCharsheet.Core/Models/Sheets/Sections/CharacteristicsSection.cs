namespace DaggerheartCharsheet.Core.Models.Sheets.Sections;

public sealed class CharacteristicsSection : VersionedSection
{
    public int Agility { get; set; }
    public bool AgilityChecked { get; set; }
    
    public int Strength { get; set; }
    public bool StrengthChecked { get; set; }
    
    public int Finesse { get; set; }
    public bool FinesseChecked { get; set; }
    
    public int Instinct { get; set; }
    public bool InstinctChecked { get; set; }
    
    public int Presence { get; set; }
    public bool PresenceChecked { get; set; }
    
    public int Knowledge { get; set; }
    public bool KnowledgeChecked { get; set; } 
}