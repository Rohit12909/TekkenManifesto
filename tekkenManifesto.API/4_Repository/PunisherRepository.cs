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
        throw new NotImplementedException();
    }

    public Punisher? DeletePunisher(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Punisher> GetAllPunishers()
    {
        throw new NotImplementedException();
    }

    public Punisher UpdatePunisher(Punisher update, int id)
    {
        throw new NotImplementedException();
    }
}
