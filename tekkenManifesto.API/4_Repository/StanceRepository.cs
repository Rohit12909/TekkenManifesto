using tekkenManifesto.API.Data;
using tekkenManifesto.API.Model;

namespace tekkenManifesto.API.Repository;

public class StanceRepository : IStanceRepository
{
    private readonly TekkenContext _tekkenContext;

    public StanceRepository(TekkenContext tekkenContext)
    {
        _tekkenContext = tekkenContext;
    }

    public Stance? CreateStance(Stance c)
    {
        _tekkenContext.Stances.Add(c);
        _tekkenContext.SaveChanges();
        return c;
    }

    public Stance? DeleteStance(Stance stance)
    {
        _tekkenContext.Stances.Remove(stance);
        _tekkenContext.SaveChanges();
        return stance;
    }

    public IEnumerable<Stance> GetAllStances()
    {
        return _tekkenContext.Stances.ToList();
    }

    public Stance GetStanceById(int id)
    {
        var stance = _tekkenContext.Stances.Find(id);
        return stance;
    }

    public Stance UpdateStance(Stance update)
    {
        _tekkenContext.Stances.Update(update);
        _tekkenContext.SaveChanges();
        return update;
    }
}
