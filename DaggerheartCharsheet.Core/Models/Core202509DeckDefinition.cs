using DaggerheartCharsheet.Core.Abstractions;
using DaggerheartCharsheet.Core.Enums;
using DaggerheartCharsheet.Core.Models.Cards;

namespace DaggerheartCharsheet.Core.Models;

public class Core202509DeckDefinition
{
    public GameVersionType Version => GameVersionType.Core202509;

    public GameVersionType[] CompatibleVersions =>
    [
        GameVersionType.TheVoid1Point5
    ];
    
    public AncestryType[] Ancestries =>
    [
        AncestryType.Clank,
        AncestryType.Drakona,
        AncestryType.Dwarf,
        AncestryType.Elf,
        AncestryType.Faerie,
        AncestryType.Faun,
        AncestryType.Firbolg,
        AncestryType.Fungril,
        AncestryType.Galapa,
        AncestryType.Giant,
        AncestryType.Goblin,
        AncestryType.Halfling,
        AncestryType.Human,
        AncestryType.Infernis,
        AncestryType.Katari,
        AncestryType.Orc,
        AncestryType.Ribbet,
        AncestryType.Smiah
    ];

    public CommunityCardType[] Communities =>
    [
        CommunityCardType.Seaborne,
        CommunityCardType.Wanderborne,
        CommunityCardType.Wildborne,
        CommunityCardType.Underborne
    ];
    
    public CharacterClass[] Classes => _characterClasses ??=
    [
        new()
        {
            Name = ClassType.Bard.ToStringFast(),
            DomainFirst = DomainType.Grace.ToStringFast(),
            DomainSecond = DomainType.Codex.ToStringFast()
        },
        new()
        {
            Name = ClassType.Druid.ToStringFast(),
            DomainFirst = DomainType.Sage.ToStringFast(),
            DomainSecond = DomainType.Arcana.ToStringFast()
        },
        new()
        {
            Name = ClassType.Guardian.ToStringFast(),
            DomainFirst = DomainType.Valor.ToStringFast(),
            DomainSecond = DomainType.Blade.ToStringFast()
        },
        new()
        {
            Name = ClassType.Ranger.ToStringFast(),
            DomainFirst = DomainType.Bone.ToStringFast(),
            DomainSecond = DomainType.Sage.ToStringFast()
        },
        new()
        {
            Name = ClassType.Rouge.ToStringFast(),
            DomainFirst = DomainType.Midnight.ToStringFast(),
            DomainSecond = DomainType.Grace.ToStringFast()
        },
        new()
        {
            Name = ClassType.Seraph.ToStringFast(),
            DomainFirst = DomainType.Splendor.ToStringFast(),
            DomainSecond = DomainType.Valor.ToStringFast()
        },
        new()
        {
            Name = ClassType.Sorcerer.ToStringFast(),
            DomainFirst = DomainType.Arcana.ToStringFast(),
            DomainSecond = DomainType.Midnight.ToStringFast()
        },
        new()
        {
            Name = ClassType.Warrior.ToStringFast(),
            DomainFirst = DomainType.Blade.ToStringFast(),
            DomainSecond = DomainType.Bone.ToStringFast()
        },
        new()
        {
            Name = ClassType.Wizard.ToStringFast(),
            DomainFirst = DomainType.Codex.ToStringFast(),
            DomainSecond = DomainType.Splendor.ToStringFast()
        }
    ];

    public Dictionary<ClassType, SubclassType[]> Subclasses => new()
    {
        [ClassType.Bard] =
        [
            SubclassType.Bard_Troubadour,
            SubclassType.Bard_Wordsmith
        ],
        [ClassType.Druid] =
        [
            SubclassType.Druid_WardenOfTheElements,
            SubclassType.Druid_WardenOfRenewal
        ],
        [ClassType.Guardian] =
        [
            SubclassType.Guardian_Stalwart,
            SubclassType.Guardian_Vengeance
        ],
        [ClassType.Ranger] =
        [
            SubclassType.Ranger_Wayfinder,
            SubclassType.Ranger_BeastBound
        ],
        [ClassType.Rouge] =
        [
            SubclassType.Rouge_Nightwalker,
            SubclassType.Rouge_Syndicate
        ],
        [ClassType.Seraph] =
        [
            SubclassType.Seraph_DivineWielder,
            SubclassType.Seraph_WingedSentinel
        ],
        [ClassType.Sorcerer] =
        [
            SubclassType.Sorcerer_PrimalOrigin,
            SubclassType.Sorcerer_ElementalOrigin
        ],
        [ClassType.Warrior] =
        [
            SubclassType.Warrior_CallOfTheBrave,
            SubclassType.Warrior_CallOfTheSlayer
        ],
        [ClassType.Wizard] =
        [
            SubclassType.Wizard_SchoolOfKnowledge,
            SubclassType.Wizard_SchoolOfWar
        ]
    };

    public SubclassCard[] SubclassCards => _subclassCards ??= Subclasses
        .SelectMany(kvp => kvp.Value.SelectMany(subclass => new SubclassCard[]
        {
            new() { Class = kvp.Key.ToStringFast(), Name = subclass.ToStringFast(), CardTier = SubclassCardTier.Foundation.ToStringFast() },
            new() { Class = kvp.Key.ToStringFast(), Name = subclass.ToStringFast(), CardTier = SubclassCardTier.Specialization.ToStringFast() },
            new() { Class = kvp.Key.ToStringFast(), Name = subclass.ToStringFast(), CardTier = SubclassCardTier.Mastery.ToStringFast() }
        }))
        .ToArray();

    private SubclassCard[]? _subclassCards;
    private CharacterClass[]? _characterClasses;

    public DomainType[] Domains =>
    [
        DomainType.Arcana,
        DomainType.Blade,
        DomainType.Bone,
        DomainType.Codex,
        DomainType.Grace,
        DomainType.Midnight,
        DomainType.Sage,
        DomainType.Splendor,
        DomainType.Valor
    ];
}