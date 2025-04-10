using Microsoft.AspNetCore.Mvc;
using tekkenManifesto.API.Model;
using tekkenManifesto.API.Service;

namespace tekkenManifesto.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class HeatEngagerController : ControllerBase
{
    private readonly IHEService _heService;

    public HeatEngagerController(IHEService heService)
    {
        _heService = heService;
    }

     // Heat Engagers
    [HttpPost("{name}")]
    public IActionResult CreateNewHE([FromBody] HeatEngager he, string name)
    {
        try
        {
            var engagers = _heService.CreateNewHE(he, name);
            return Ok(he);
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }

    [HttpGet]
    public IActionResult GetAllHE()
    {
        var comboList = _heService.GetAllHE();
        return Ok(comboList);
    }

    [HttpPatch("updateHE/{id}")]
    public IActionResult UpdateHE([FromBody] HeatEngager update, int id)
    {
        try
        {
            var updated = _heService.UpdateHE(update, id);
            return Ok();
        }
        catch (Exception e)
        {
            return Conflict(e.Message);
        }
    }

    [HttpDelete("deleteHE/{name}")]
    public IActionResult DeleteHE(int id)
    {
        try
        {
            var deleteHE = _heService.DeleteHE(id);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}