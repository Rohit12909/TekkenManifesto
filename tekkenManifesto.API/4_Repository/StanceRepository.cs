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
        throw new NotImplementedException();
    }

    public Stance? DeleteStance(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Stance> GetAllStances()
    {
        throw new NotImplementedException();
    }

    public Stance UpdateStance(Stance update, int id)
    {
        throw new NotImplementedException();
    }
}
