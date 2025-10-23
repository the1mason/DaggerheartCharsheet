namespace DaggerheartCharsheet.Core.Models.Sheets.Sections;

public sealed class DamageAndHealthSection : VersionedSection
{
    public int ThresholdMajor { get; set; }
    public int ThresholdSevere { get; set; }
    
    public int HitPointsMax { get; set; }
    public int HitPointsCrossed { get; set; }
    
    public int StressMax { get; set; }
    public int StressCrossed { get; set; }
}