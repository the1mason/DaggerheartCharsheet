using DaggerheartCharsheet.Core.Enums;
using DaggerheartCharsheet.Core.Models;
using DaggerheartCharsheet.Core.Models.Cards;

namespace DaggerheartCharsheet.Core.Abstractions;

public interface IDeckDefinition
{
    GameVersionType Version { get; }
    GameVersionType[] CompatibleVersions { get; }
    AncestryType[] Ancestries { get; }
    CommunityType[] Communities { get; }
    CharacterClass[] Classes { get; }
    Dictionary<ClassType, SubclassType[]> Subclasses { get; }
    SubclassCard[] SubclassCards { get; }
    DomainType[] Domains { get; }
    DomainCard[] DomainCards { get; }
}