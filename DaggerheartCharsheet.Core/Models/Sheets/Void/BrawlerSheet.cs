using DaggerheartCharsheet.Core.Enums;
using DaggerheartCharsheet.Core.Models.Sheets.Sections;
using DaggerheartCharsheet.Core.Models.Sheets.Sections.Brawler;

namespace DaggerheartCharsheet.Core.Models.Sheets.Void;

public sealed class BrawlerSheet : CommonSheet
{
    public DomainType DomainFirst { get; set; }
    public DomainType DomainSecond { get; set; }
    
    public BasicInfoSection? BasicInfo { get; set; }
    public DefenceSection? Defence { get; set; }
    public CharacteristicsSection? Characteristics { get; set; }
    public DamageAndHealthSection? DamageAndHealth { get; set; }
    public HopeSection? Hope { get; set; }
    public ExperiencesSection? Experiences { get; set; }
    public GoldSection? Gold { get; set; }
    public ActiveWeaponsSection? ActiveWeapons { get; set; }
    public ArmorSection? Armor { get; set; }
    public InventorySection? Inventory { get; set; }
    public BackgroundsAndConnectionsSection? BackgroundsAndConnections { get; set; }
    public CardsSection? Cards { get; set; }
    public LevelingCheckListItem? LevelingCheckList { get; set; }
    
    public BrawlerFeatureSection? ClassFeature { get; set; }
}