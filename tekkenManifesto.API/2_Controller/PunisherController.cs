using Microsoft.AspNetCore.Mvc;
using tekkenManifesto.API.Model;
using tekkenManifesto.API.Service;

namespace tekkenManifesto.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class PunisherController : ControllerBase
{
    private readonly IPunisherService _punisherService;

    public PunisherController(IPunisherService punisherService)
    {
        _punisherService = punisherService;
    }

    // Punishers
    [HttpPost("{name}")]
    public IActionResult CreatePunisher([FromBody] Punisher p, string name)
    {
        try
        {
            var punish = _punisherService.CreatePunisher(p, name);
            return Ok(p);
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpGet]
    public IActionResult GetAllPunishers()
    {
        var punishList = _punisherService.GetAllPunishers();
        return Ok(punishList);
    }

    [HttpPatch("updatePunisher/{id}")]
    public IActionResult UpdatePunisher([FromBody] Punisher update, int id)
    {
        try
        {
            var updated = _punisherService.UpdatePunisher(update, id);
            return Ok();
        }
        catch (Exception e)
        {
            return Conflict(e.Message);
        }
    }

    [HttpDelete("deletePunisher/{id}")]
    public IActionResult DeletePunisher(int id)
    {
        try
        {
            var deletePunish = _punisherService.DeletePunisher(id);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

}