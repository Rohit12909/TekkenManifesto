using Microsoft.AspNetCore.Mvc;
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

    // CRUD Combos

    // CRUD HE, Launchers, Stances, Punishers
}