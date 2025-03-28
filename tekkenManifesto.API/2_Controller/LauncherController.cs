using Microsoft.AspNetCore.Mvc;
using tekkenManifesto.API.Model;
using tekkenManifesto.API.Service;

namespace tekkenManifesto.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class LauncherController : ControllerBase
{
    private readonly ILauncherService _launcherService;

    public LauncherController(ILauncherService launcherService)
    {
        _launcherService = launcherService;
    }

    // Launchers
    [HttpPost]
    public IActionResult CreateLauncher([FromBody] Combo c)
    {
        try
        {
            return Ok(c);
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpGet]
    public IActionResult GetAllLaunchers()
    {
        var comboList = _launcherService.GetAllLaunchers();
        return Ok(comboList);
    }

    [HttpPatch("updateLauncher/{id}")]
    public IActionResult UpdateLauncher([FromBody] Combo update, int id)
    {
        try
        {
            return Ok();
        }
        catch (Exception e)
        {
            return Conflict(e.Message);
        }
    }

    [HttpDelete("deleteLauncher/{id}")]
    public IActionResult DeleteLauncher(int id)
    {
        try
        {
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}