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
}