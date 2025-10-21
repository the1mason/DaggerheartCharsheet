using DaggerheartCharsheet.Core.Enums;

namespace DaggerheartCharsheet.Core.Models.Cards;

public sealed record SubclassCard
{
    public string Class { get; init; }
    public string Name { get; init; }
    public string CardTier { get; init; }
    public bool BuiltIn { get; init; }

    public SubclassCard(ClassType classType, SubclassType subclassType, SubclassCardTier tier)
    {
        Class = classType.ToStringFast();
        Name = subclassType.ToStringFast();
        CardTier = tier.ToStringFast();
        BuiltIn = true;
    }
    
    public SubclassCard(string className, string cardName, string cardTier)
    {
        Class = className;
        Name = cardName;
        CardTier = cardTier;
        BuiltIn = false;
    }
}