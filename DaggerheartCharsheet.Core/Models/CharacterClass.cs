using DaggerheartCharsheet.Core.Enums;

namespace DaggerheartCharsheet.Core.Models;

public sealed record CharacterClass
{
    public required string Name { get; init;  }
    public required string DomainFirst { get; init;  }
    public required string DomainSecond { get; init;  }
}