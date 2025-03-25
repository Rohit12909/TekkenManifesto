using tekkenManifesto.API.Repository;

namespace tekkenManifesto.API.Service;

public class ComboService : IComboService
{
    private readonly IComboRepository _comboRepository;

    public ComboService(IComboRepository comboRepository)
    {
        _comboRepository = comboRepository;
    }
}