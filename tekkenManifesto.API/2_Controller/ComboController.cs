using Microsoft.AspNetCore.Mvc;
using tekkenManifesto.API.Model;
using tekkenManifesto.API.Service;

namespace tekkenManifesto.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class ComboController : ControllerBase
{
    private readonly IComboService _comboService;

    public ComboController(IComboService comboService)
    {
        _comboService = comboService;
    }

    // COMBOS
    [HttpPost]
    public IActionResult CreateNewCombo([FromBody] Combo c)
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
    public IActionResult GetAllCombos()
    {
        var comboList = _comboService.GetAllCombos();
        return Ok(comboList);
    }

    [HttpPatch("updateCombo/{id}")]
    public IActionResult UpdateCombo([FromBody] Combo update, int id)
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

    [HttpDelete("delete/{id}")]
    public IActionResult DeleteCombo(int id)
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

   

    // Launchers
    [HttpPost("launcher")]
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

    [HttpGet("getLauncher")]
    public IActionResult GetAllLaunchers()
    {
        var comboList = _comboService.GetAllLaunchers();
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

    // Stances
    [HttpPost("stance")]
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

    [HttpGet("getStance")]
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

    // Punishers
    [HttpPost("punisher")]
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

    [HttpGet("getPunisher")]
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