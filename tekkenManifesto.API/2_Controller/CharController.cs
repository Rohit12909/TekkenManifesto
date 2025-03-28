using Microsoft.AspNetCore.Mvc;
using tekkenManifesto.API.DTO;
using tekkenManifesto.API.Model;
using tekkenManifesto.API.Service;

namespace tekkenManifesto.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class CharController : ControllerBase
{
    private readonly ICharService _charService;

    public CharController(ICharService charService)
    {
        _charService = charService;
    }

    [HttpPost]
    public IActionResult CreateNewChar([FromBody] CharInDTO newChar)
    {
        try
        {
            var chars = _charService.CreateNewChar(newChar);
            return Ok(chars);
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpGet]
    public IActionResult GetAllChars()
    {
        var charList = _charService.GetAllChars();
        return Ok(charList);
    }

    [HttpGet("char/{name}")]
    public IActionResult GetCharByName(string name)
    {
        var charList = _charService.GetCharByName(name);
        return Ok(charList);
    }

    [HttpPatch("update/{id}")]
    public IActionResult UpdateChar([FromBody] CharInDTO update, int id)
    {
        try
        {
            var updated = _charService.UpdateChar(update, id);
            return Ok(updated);
        }
        catch (Exception e)
        {
            return Conflict(e.Message);
        }
    }

    [HttpDelete("delete/{id}")]
    public IActionResult DeleteChar(int id)
    {
        try
        {
            var deleteChar = _charService.DeleteChar(id);
            return Ok(deleteChar);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    
}