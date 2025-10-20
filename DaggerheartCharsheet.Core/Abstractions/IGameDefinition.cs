using DaggerheartCharsheet.Core.Enums;

namespace DaggerheartCharsheet.Core.Abstractions;

public interface IGameDefinition
{
    GameVersionType Version { get; }
    GameVersionType[] CompatibleVersions { get; }
    AncestryType[] Ancestries { get; }
    CommunityCardType[] Communities { get; }
    ClassType[] Classes { get; }
    Dictionary<ClassType, SubclassType[]> Subclasses { get; }
    DomainType[] Domains { get; }
}
