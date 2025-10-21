using DaggerheartCharsheet.Core.Enums;

namespace DaggerheartCharsheet.Core.Models.Cards;

public sealed record SubclassCard
{
    public ClassType Class { get; init; }
    public SubclassType Name { get; init; }
    public SubclassCardTier CardTier { get; init; }

    public SubclassCard(ClassType classType, SubclassType subclassType, SubclassCardTier tier)
    {
        Class = classType;
        Name = subclassType;
        CardTier = tier;
    }
}