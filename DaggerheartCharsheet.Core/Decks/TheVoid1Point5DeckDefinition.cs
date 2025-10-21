using DaggerheartCharsheet.Core.Abstractions;
using DaggerheartCharsheet.Core.Constants.DomainCards;
using DaggerheartCharsheet.Core.Enums;
using DaggerheartCharsheet.Core.Models;
using DaggerheartCharsheet.Core.Models.Cards;

namespace DaggerheartCharsheet.Core.Decks;

public class TheVoid1Point5DeckDefinition : IDeckDefinition
{
    public GameVersionType Version => GameVersionType.TheVoid1Point5;

    public GameVersionType[] CompatibleVersions { get; } = [GameVersionType.Core202509];

    public AncestryType[] Ancestries { get; } =
    [
        AncestryType.Aetheris,
        AncestryType.Earthkin,
        AncestryType.Emberkin,
        AncestryType.Gnome,
        AncestryType.Skykin,
        AncestryType.Tidekin
    ];

    public CommunityCardType[] Communities { get; } = [];

    public CharacterClass[] Classes { get; } =
    [
        new (ClassType.Assassin, DomainType.Grace, DomainType.Blade),
        new (ClassType.Brawler, DomainType.Bone, DomainType.Valor),
        new (ClassType.Warlock, DomainType.Dread, DomainType.Grace),
        new (ClassType.Witch, DomainType.Dread, DomainType.Sage)
    ];
    
    public Dictionary<ClassType, SubclassType[]> Subclasses { get; } = new()
    {
        [ClassType.Assassin] =
        [
            SubclassType.Assassin_PoisonersGuild,
            SubclassType.Assassin_ExecutionersGuild
        ],
        [ClassType.Brawler] =
        [
            SubclassType.Brawler_Juggernaut,
            SubclassType.Brawler_MartialArtist
        ],
        [ClassType.Warlock] =
        [
            SubclassType.Warlock_PactOfTheWraithful,
            SubclassType.Warlock_PactOfTheEndless
        ],
        [ClassType.Witch] =
        [
            SubclassType.Witch_Moon,
            SubclassType.Witch_Hedge
        ]
    };
    public SubclassCard[] SubclassCards => _subclassCards ??= Subclasses
        .SelectMany(kvp => kvp.Value.SelectMany(subclass => new SubclassCard[]
        {
            new(kvp.Key, subclass, SubclassCardTier.Foundation),
            new(kvp.Key, subclass, SubclassCardTier.Specialization),
            new(kvp.Key, subclass, SubclassCardTier.Mastery)
        }))
        .ToArray();

    public DomainType[] Domains { get; } = [ DomainType.Dread ];

    public DomainCard[] DomainCards { get; } =
    [
        new(DreadCardType.BlightingStrike, DomainType.Dread, DomainCardActionType.Spell, level: 1, recallCost: 1),
        new(DreadCardType.UmbralVeil, DomainType.Dread, DomainCardActionType.Spell, level: 1, recallCost: 1),
        new(DreadCardType.VoiceOfDread, DomainType.Dread, DomainCardActionType.Spell, level: 1, recallCost: 0),
        new(DreadCardType.HideousRetribution, DomainType.Dread, DomainCardActionType.Spell, level: 2, recallCost: 2),
        new(DreadCardType.SiphonEssence, DomainType.Dread, DomainCardActionType.Spell, level: 2, recallCost: 1),
    ];
    
    private SubclassCard[]? _subclassCards;
}