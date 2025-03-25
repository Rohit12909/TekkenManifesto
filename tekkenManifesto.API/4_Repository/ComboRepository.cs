using tekkenManifesto.API.Data;

namespace tekkenManifesto.API.Repository;

public class ComboRepository : IComboRepository
{
    private readonly TekkenContext _tekkenContext;

    public ComboRepository(TekkenContext tekkenContext)
    {
        _tekkenContext = tekkenContext;
    }
}