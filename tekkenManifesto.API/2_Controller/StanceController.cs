using Microsoft.AspNetCore.Mvc;
using tekkenManifesto.API.Model;
using tekkenManifesto.API.Service;

namespace tekkenManifesto.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class StanceController : ControllerBase
{
    private readonly IStanceService _stanceService;

    public StanceController(IStanceService stanceService)
    {
        _stanceService = stanceService;
    }

    // Stances
    [HttpPost("{name}")]
    public IActionResult CreateStance([FromBody] Stance stan, string name)
    {
        try
        {
            var stances = _stanceService.CreateStance(stan, name);
            return Ok(stan);
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpGet]
    public IActionResult GetAllStances()
    {
        var stanceList = _stanceService.GetAllStances();
        return Ok(stanceList);
    }

    [HttpPatch("updateStance/{id}")]
    public IActionResult UpdateStance([FromBody] Stance update, int id)
    {
        try
        {
            var updated = _stanceService.UpdateStance(update, id);
            return Ok();
        }
        catch (Exception e)
        {
            return Conflict(e.Message);
        }
    }

    [HttpDelete("deleteStance/{id}")]
    public IActionResult DeleteStance(int id)
    {
        try
        {
            var deleteStance = _stanceService.DeleteStance(id);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

}