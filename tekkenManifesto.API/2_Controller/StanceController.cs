using Microsoft.AspNetCore.Mvc;
using tekkenManifesto.API.Model;
using tekkenManifesto.API.Service;

namespace tekkenManifesto.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class StanceController : ControllerBase
{
    private readonly IComboService _comboService;

    public StanceController(IComboService comboService)
    {
        _comboService = comboService;
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
        var comboList = _comboService.GetAllStances();
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