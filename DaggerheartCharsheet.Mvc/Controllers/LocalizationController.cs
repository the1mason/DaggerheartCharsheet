using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace DaggerheartCharsheet.Mvc.Controllers
{
    [Route("localization")]
    public class LocalizationController : Controller
    {
        [HttpPost("set")]
        public IActionResult SetLanguage([FromQuery] string culture)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );
            Response.Headers.Append("Hx-Refresh", "true");
            return NoContent();
        }
    }
}
