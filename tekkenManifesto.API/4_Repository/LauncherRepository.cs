using tekkenManifesto.API.Data;
using tekkenManifesto.API.Model;

namespace tekkenManifesto.API.Repository;

public class LauncherRepository : ILauncherRepository
{
    private readonly TekkenContext _tekkenContext;

    public LauncherRepository(TekkenContext tekkenContext)
    {
        _tekkenContext = tekkenContext;
    }

    public Launcher? CreateLauncher(Launcher c)
    {
        throw new NotImplementedException();
    }

    public Launcher? DeleteLauncher(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Launcher> GetAllLaunchers()
    {
        throw new NotImplementedException();
    }

    public Launcher UpdateLauncher(Launcher update, int id)
    {
        throw new NotImplementedException();
    }
}
