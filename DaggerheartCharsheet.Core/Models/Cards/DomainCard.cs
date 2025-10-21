using DaggerheartCharsheet.Core.Enums;

namespace DaggerheartCharsheet.Core.Models.Cards;

public sealed record DomainCard
{
    public string Name { get; init; }
    public string Domain { get; init; }
    public string ActionType { get; init; }
    public int Level { get; init; }
    public int RecallCost { get; init; }
    public bool BuiltIn { get; private init; } = false;

    public DomainCard(string name, DomainType domainType, DomainCardActionType actionType, int level, int recallCost)
    {
        Name = name;
        Domain = domainType.ToStringFast();
        ActionType = actionType.ToStringFast();
        Level = level;
        RecallCost = recallCost;
        BuiltIn = true;
    }

    public DomainCard(string name, string domain, string actionType, int level, int recallCost)
    {
        Name = name;
        Domain = domain;
        ActionType = actionType;
        Level = level;
        RecallCost = recallCost;
        BuiltIn = false;
    }
    
}