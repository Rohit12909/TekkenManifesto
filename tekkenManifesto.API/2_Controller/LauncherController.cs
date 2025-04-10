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
    [HttpPost("{name}")]
    public IActionResult CreateLauncher([FromBody] Launcher launch, string name)
    {
        try
        {
            var launchers = _launcherService.CreateLauncher(launch, name);
            return Ok(launch);
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpGet]
    public IActionResult GetAllLaunchers()
    {
        var launchList = _launcherService.GetAllLaunchers();
        return Ok(launchList);
    }

    [HttpPatch("updateLauncher/{id}")]
    public IActionResult UpdateLauncher([FromBody] Launcher update, int id)
    {
        try
        {
            var updated = _launcherService.UpdateLauncher(update, id);
            return Ok();
        }
        catch (Exception e)
        {
            return Conflict(e.Message);
        }
    }

    [HttpDelete("deleteLauncher/{name}")]
    public IActionResult DeleteLauncher(int id)
    {
        try
        {
            var deleteLauncher = _launcherService.DeleteLauncher(id);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}