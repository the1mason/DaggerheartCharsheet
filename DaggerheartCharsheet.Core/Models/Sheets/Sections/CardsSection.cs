using DaggerheartCharsheet.Core.Enums;
using DaggerheartCharsheet.Core.Models.Cards;

namespace DaggerheartCharsheet.Core.Models.Sheets.Sections;

public sealed class CardsSection : VersionedSection
{
    public Dictionary<GameVersionType, DomainCard[]> DomainCards { get; set; } = new();
    public Dictionary<GameVersionType, SubclassCard[]> SubclassCards { get; set; } = new();
}