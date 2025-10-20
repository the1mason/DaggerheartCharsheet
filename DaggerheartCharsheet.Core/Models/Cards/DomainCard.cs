using DaggerheartCharsheet.Core.Enums;

namespace DaggerheartCharsheet.Core.Models.Cards;

public sealed record DomainCard
{
    public required string Name { get; init; }
    public required string Domain { get; init; }
    public required string ActionType { get; init; }
    public required string Level { get; init; }
    public required string RecallCost { get; init; }
}