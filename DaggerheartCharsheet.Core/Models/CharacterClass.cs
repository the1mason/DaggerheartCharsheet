using DaggerheartCharsheet.Core.Enums;

namespace DaggerheartCharsheet.Core.Models;

public sealed record CharacterClass
{
    public string Name { get; init;  }
    public string DomainFirst { get; init;  }
    public string DomainSecond { get; init;  }
    
    public bool BuiltIn { get; private init; }

    public CharacterClass(ClassType type, DomainType first, DomainType second)
    {
        Name = type.ToStringFast();
        DomainFirst = first.ToStringFast();
        DomainSecond = second.ToStringFast();
        BuiltIn = true;
    }
    
    public CharacterClass(string name, string domainFirst, string domainSecond)
    {
        Name = name;
        DomainFirst = domainFirst;
        DomainSecond = domainSecond;
        BuiltIn = false;
    }
    
}