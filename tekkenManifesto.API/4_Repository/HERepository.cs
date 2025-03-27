using tekkenManifesto.API.Data;
using tekkenManifesto.API.Model;

namespace tekkenManifesto.API.Repository;

public class HERepository : IHERepository
{
    private readonly TekkenContext _tekkenContext;

    public HERepository(TekkenContext tekkenContext)
    {
        _tekkenContext = tekkenContext;
    }

    public HeatEngager? CreateNewHE(HeatEngager c)
    {
        throw new NotImplementedException();
    }

    public HeatEngager? DeleteHE(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<HeatEngager> GetAllHE()
    {
        throw new NotImplementedException();
    }

    public HeatEngager UpdateHE(HeatEngager update, int id)
    {
        throw new NotImplementedException();
    }
}
