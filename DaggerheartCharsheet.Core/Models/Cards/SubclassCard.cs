using DaggerheartCharsheet.Core.Enums;

namespace DaggerheartCharsheet.Core.Models.Cards;

public sealed record SubclassCard
{
    public required string Class { get; init; }
    public required string Name { get; init; }
    public required string CardTier { get; init; }
}