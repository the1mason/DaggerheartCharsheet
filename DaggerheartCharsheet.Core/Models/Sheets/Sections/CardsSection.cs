using DaggerheartCharsheet.Core.Enums;
using DaggerheartCharsheet.Core.Models.Cards;

namespace DaggerheartCharsheet.Core.Models.Sheets.Sections;

public sealed class CardsSection : VersionedSection
{
    // here the type is wrong
    // realistically it should be just a pair of card type and version type and then the
    // display logic should retreive the correct card based on version and type
    // maybe make a generic entity for that exaxt scenario as it is used often
    public Dictionary<GameVersionType, DomainCard[]> DomainCards { get; set; } = new();
    public Dictionary<GameVersionType, SubclassCard[]> SubclassCards { get; set; } = new();
}