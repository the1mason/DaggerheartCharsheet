using DaggerheartCharsheet.Core.Models.Sheets.Core;
using Microsoft.AspNetCore.Mvc;

namespace DaggerheartCharsheet.Mvc.Controllers;

[Controller]
[Route("game/[controller]")]
public class Core202509Controller : Controller
{
    [HttpGet("edit/seraph")]
    public IActionResult Seraph()
    {
        return View(new SeraphSheet());
    }
}