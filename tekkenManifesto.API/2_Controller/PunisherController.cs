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
}