using DaggerheartCharsheet.Core.Enums;

namespace DaggerheartCharsheet.Core.Models.Sheets;

public class CommonSheet
{
    public Guid Id { get; set; }
    public GameVersionType Version { get; set; }
    public ClassType Class { get; set; }
    public string Name { get; set; }
}