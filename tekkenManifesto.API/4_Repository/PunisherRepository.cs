using tekkenManifesto.API.Data;
using tekkenManifesto.API.Model;

namespace tekkenManifesto.API.Repository;

public class PunisherRepository : IPunisherRepository
{
    private readonly TekkenContext _tekkenContext;

    public PunisherRepository(TekkenContext tekkenContext)
    {
        _tekkenContext = tekkenContext;
    }

    public Punisher? CreatePunisher(Punisher c)
    {
        _tekkenContext.Punishers.Add(c);
        _tekkenContext.SaveChanges();
        return c;
    }

    public Punisher? DeletePunisher(Punisher punish)
    {
        _tekkenContext.Punishers.Remove(punish);
        _tekkenContext.SaveChanges();
        return punish;
    }

    public IEnumerable<Punisher> GetAllPunishers()
    {
        return _tekkenContext.Punishers.ToList();
    }

    public Punisher GetPunisherById(int id)
    {
        var punish = _tekkenContext.Punishers.Find(id);
        return punish;
    }

    public Punisher UpdatePunisher(Punisher update)
    {
        _tekkenContext.Punishers.Update(update);
        _tekkenContext.SaveChanges();
        return update;
    }
}
