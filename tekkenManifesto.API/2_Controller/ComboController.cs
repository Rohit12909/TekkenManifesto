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
    [HttpPost("{name}")]
    public IActionResult CreateNewCombo([FromBody] Combo c, string name)
    {
        try
        {
            var combos = _comboService.CreateNewCombo(c, name);
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
            var updated = _comboService.UpdateCombo(update, id);
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
            var deleteChar = _comboService.DeleteCombo(id);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}