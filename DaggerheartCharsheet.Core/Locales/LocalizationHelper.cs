using DaggerheartCharsheet.Core.Enums;
using Microsoft.Extensions.Localization;

namespace DaggerheartCharsheet.Core.Locales;

public class LocalizationHelper(IStringLocalizer<Core202509> coreLocalizer)
{
    public IStringLocalizer GetStringLocalizerByVersion(GameVersionType versionType) => versionType switch
    {
        GameVersionType.Core202509 => coreLocalizer,
        _ => throw new NotImplementedException($"No localizer implemented for version type {versionType}")
    };

    public IStringLocalizer this[GameVersionType versionType] => GetStringLocalizerByVersion(versionType);
}