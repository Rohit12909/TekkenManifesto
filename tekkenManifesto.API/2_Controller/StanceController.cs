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
    [HttpPost]
    public IActionResult CreateStance([FromBody] Combo c)
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
    public IActionResult GetAllStances()
    {
        var comboList = _stanceService.GetAllStances();
        return Ok(comboList);
    }

    [HttpPatch("updateStance/{id}")]
    public IActionResult UpdateStance([FromBody] Combo update, int id)
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

    [HttpDelete("deleteStance/{id}")]
    public IActionResult DeleteStance(int id)
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