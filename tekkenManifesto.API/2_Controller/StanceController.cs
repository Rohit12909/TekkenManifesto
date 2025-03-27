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
}