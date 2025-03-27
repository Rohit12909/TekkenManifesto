using Microsoft.AspNetCore.Mvc;
using tekkenManifesto.API.Model;
using tekkenManifesto.API.Service;

namespace tekkenManifesto.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class PunisherController : ControllerBase
{
    private readonly IComboService _comboService;

    public PunisherController(IComboService comboService)
    {
        _comboService = comboService;
    }

    // Punishers
    [HttpPost]
    public IActionResult CreatePunisher([FromBody] Combo c)
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
    public IActionResult GetAllPunishers()
    {
        var comboList = _comboService.GetAllPunishers();
        return Ok(comboList);
    }

    [HttpPatch("updatePunisher/{id}")]
    public IActionResult UpdatePunisher([FromBody] Combo update, int id)
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

    [HttpDelete("deletePunisher/{id}")]
    public IActionResult DeletePunisher(int id)
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