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
        _tekkenContext.HeatEngagers.Add(c);
        _tekkenContext.SaveChanges();
        return c;
    }

    public HeatEngager? DeleteHE(HeatEngager he)
    {
        _tekkenContext.HeatEngagers.Remove(he);
        _tekkenContext.SaveChanges();
        return he;
    }

    public IEnumerable<HeatEngager> GetAllHE()
    {
        return _tekkenContext.HeatEngagers.ToList();
    }

    public HeatEngager GetHEById(int id)
    {
        var heat = _tekkenContext.HeatEngagers.Find(id);
        return heat;
    }

    public HeatEngager UpdateHE(HeatEngager update)
    {
        _tekkenContext.HeatEngagers.Update(update);
        _tekkenContext.SaveChanges();
        return update;
    }
}
