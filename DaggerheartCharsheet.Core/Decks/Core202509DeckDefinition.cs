using DaggerheartCharsheet.Core.Abstractions;
using DaggerheartCharsheet.Core.Constants.DomainCards;
using DaggerheartCharsheet.Core.Enums;
using DaggerheartCharsheet.Core.Models;
using DaggerheartCharsheet.Core.Models.Cards;

namespace DaggerheartCharsheet.Core.Decks;

public class Core202509DeckDefinition : IDeckDefinition
{
    public GameVersionType Version => GameVersionType.Core202509;

    public GameVersionType[] CompatibleVersions { get; } =
    [
        GameVersionType.TheVoid1Point5
    ];

    public AncestryType[] Ancestries { get; } =
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

    public CommunityType[] Communities { get; } =
    [
        CommunityType.Seaborne,
        CommunityType.Wanderborne,
        CommunityType.Wildborne,
        CommunityType.Underborne
    ];

    public CharacterClass[] Classes { get; } =
    [
        new (ClassType.Bard, DomainType.Grace, DomainType.Codex),
        new (ClassType.Druid, DomainType.Sage, DomainType.Arcana),
        new (ClassType.Guardian, DomainType.Valor, DomainType.Blade),
        new (ClassType.Ranger, DomainType.Bone, DomainType.Sage),
        new (ClassType.Rouge, DomainType.Midnight, DomainType.Grace),
        new (ClassType.Seraph, DomainType.Splendor, DomainType.Valor),
        new (ClassType.Sorcerer, DomainType.Arcana, DomainType.Midnight),
        new (ClassType.Warrior, DomainType.Blade, DomainType.Bone),
        new (ClassType.Wizard, DomainType.Codex, DomainType.Splendor)
    ];

    public Dictionary<ClassType, SubclassType[]> Subclasses { get; } = new()
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
            new(kvp.Key, subclass, SubclassCardTier.Foundation),
            new(kvp.Key, subclass, SubclassCardTier.Specialization),
            new(kvp.Key, subclass, SubclassCardTier.Mastery)
        }))
        .ToArray();

    public DomainType[] Domains { get; } =
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

    // mamma mia
    public DomainCard[] DomainCards { get; } =
    [
        // arcana
        new(ArcanaCardName.RuneWard, DomainType.Arcana, DomainCardActionType.Spell, level: 1, recallCost: 0),
        new(ArcanaCardName.UnleashChaos, DomainType.Arcana, DomainCardActionType.Spell, level: 1, recallCost: 1),
        new(ArcanaCardName.WallWalk, DomainType.Arcana, DomainCardActionType.Spell, level: 1, recallCost: 1),
        new(ArcanaCardName.CinderGrasp, DomainType.Arcana, DomainCardActionType.Spell, level: 2, recallCost: 1),
        new(ArcanaCardName.FloatingEye, DomainType.Arcana, DomainCardActionType.Spell, level: 2, recallCost: 0),
        // blade
        new(BladeCardName.GetBackUp, DomainType.Blade, DomainCardActionType.Ability, level: 1, recallCost: 1),
        new(BladeCardName.NotGoodEnough, DomainType.Blade, DomainCardActionType.Ability, level: 1, recallCost: 1),
        new(BladeCardName.Whirlwind, DomainType.Blade, DomainCardActionType.Ability, level: 1, recallCost: 0),
        new(BladeCardName.ASoldiersBond, DomainType.Blade, DomainCardActionType.Ability, level: 2, recallCost: 1),
        new(BladeCardName.Reckless, DomainType.Blade, DomainCardActionType.Ability, level: 2, recallCost: 1),
        // bone
        new(BoneCardName.DeftManeuvers, DomainType.Bone, DomainCardActionType.Ability, level: 1, recallCost: 0),
        new(BoneCardName.SeeItComing, DomainType.Bone, DomainCardActionType.Ability, level: 1, recallCost: 0),
        new(BoneCardName.Untouchable, DomainType.Bone, DomainCardActionType.Ability, level: 1, recallCost: 1),
        new(BoneCardName.Ferocity, DomainType.Bone, DomainCardActionType.Ability, level: 2, recallCost: 2),
        new(BoneCardName.StrategicApproach, DomainType.Bone, DomainCardActionType.Ability, level: 2, recallCost: 1),
        // codex
        new(CodexCardName.BookOfAva, DomainType.Codex, DomainCardActionType.Grimoire, level: 1, recallCost: 2),
        new(CodexCardName.BookOfIlliat, DomainType.Codex, DomainCardActionType.Grimoire, level: 1, recallCost: 2),
        new(CodexCardName.BookOfTyfar, DomainType.Codex, DomainCardActionType.Grimoire, level: 1, recallCost: 2),
        new(CodexCardName.BookOfSitil, DomainType.Codex, DomainCardActionType.Grimoire, level: 2, recallCost: 2),
        new(CodexCardName.BookOfVagras, DomainType.Codex, DomainCardActionType.Grimoire, level: 2, recallCost: 2),
        // grace
        new(GraceCardName.DeftDeceiver, DomainType.Grace, DomainCardActionType.Ability, level: 1, recallCost: 0),
        new(GraceCardName.Enrapture, DomainType.Grace, DomainCardActionType.Spell, level: 1, recallCost: 0),
        new(GraceCardName.InspirationalWords, DomainType.Grace, DomainCardActionType.Ability, level: 1, recallCost: 1),
        new(GraceCardName.TellNoLies, DomainType.Grace, DomainCardActionType.Spell, level: 2, recallCost: 1),
        new(GraceCardName.Troublemaker, DomainType.Grace, DomainCardActionType.Ability, level: 2, recallCost: 2),
        // midnight
        new (MidnightCardName.PickAndPull, DomainType.Midnight, DomainCardActionType.Ability, level: 1, recallCost: 0),
        new (MidnightCardName.RainOfBlades, DomainType.Midnight, DomainCardActionType.Spell, level: 1, recallCost: 1),
        new (MidnightCardName.UncannyDisguise, DomainType.Midnight, DomainCardActionType.Spell, level: 2, recallCost: 0),
        new (MidnightCardName.MidnightSpirit, DomainType.Midnight, DomainCardActionType.Spell, level: 2, recallCost: 1),
        new (MidnightCardName.ShadowBind, DomainType.Midnight, DomainCardActionType.Spell, level: 2, recallCost: 0),
        // sage
        new (SageCardName.GiftedTracker , DomainType.Sage, DomainCardActionType.Ability, level: 1, recallCost: 0),
        new (SageCardName.NaturesTongue , DomainType.Sage, DomainCardActionType.Ability, level: 1, recallCost: 0),
        new (SageCardName.ViciousEntangle , DomainType.Sage, DomainCardActionType.Spell, level: 1, recallCost: 1),
        new (SageCardName.ConjureSwarm , DomainType.Sage, DomainCardActionType.Spell, level: 2, recallCost: 1),
        new (SageCardName.NaturalFamiliar , DomainType.Sage, DomainCardActionType.Spell, level: 2, recallCost: 1),
        // splendor
        new (SplendorCardName.BoltBeacon , DomainType.Splendor, DomainCardActionType.Spell, level: 1, recallCost: 1),
        new (SplendorCardName.MendingTouch , DomainType.Splendor, DomainCardActionType.Spell, level: 1, recallCost: 1),
        new (SplendorCardName.Reassurance , DomainType.Splendor, DomainCardActionType.Ability, level: 1, recallCost: 0),
        new (SplendorCardName.FinalWords , DomainType.Splendor, DomainCardActionType.Spell, level: 2, recallCost: 1),
        new (SplendorCardName.HealingHands , DomainType.Splendor, DomainCardActionType.Spell, level: 2, recallCost: 1),
        // valor
        new (ValorCardName.BareBones , DomainType.Valor, DomainCardActionType.Ability, level: 1, recallCost: 0),
        new (ValorCardName.ForcefulPush , DomainType.Valor, DomainCardActionType.Ability, level: 1, recallCost: 0),
        new (ValorCardName.AmYourShield , DomainType.Valor, DomainCardActionType.Ability, level: 1, recallCost: 1),
        new (ValorCardName.BodyBasher , DomainType.Valor, DomainCardActionType.Ability, level: 2, recallCost: 1),
        new (ValorCardName.BoldPresence , DomainType.Valor, DomainCardActionType.Ability, level: 2, recallCost: 0),
    ];

    private SubclassCard[]? _subclassCards;
}