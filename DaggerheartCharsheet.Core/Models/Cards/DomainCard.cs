using DaggerheartCharsheet.Core.Enums;

namespace DaggerheartCharsheet.Core.Models.Cards;

public sealed record DomainCard
{
    public string Name { get; init; }
    public DomainType Domain { get; init; }
    public DomainCardActionType ActionType { get; init; }
    public int Level { get; init; }
    public int RecallCost { get; init; }

    public DomainCard(string name, DomainType domainType, DomainCardActionType actionType, int level, int recallCost)
    {
        Name = name;
        Domain = domainType;
        ActionType = actionType;
        Level = level;
        RecallCost = recallCost;
    }
}