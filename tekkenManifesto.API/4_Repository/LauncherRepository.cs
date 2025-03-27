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
        _tekkenContext.Launchers.Add(c);
        _tekkenContext.SaveChanges();
        return c;
    }

    public Launcher? DeleteLauncher(Launcher launch)
    {
        _tekkenContext.Launchers.Remove(launch);
        _tekkenContext.SaveChanges();
        return launch;
    }

    public IEnumerable<Launcher> GetAllLaunchers()
    {
        return _tekkenContext.Launchers.ToList();
    }

    public Launcher GetLauncherById(int id)
    {
        var launch = _tekkenContext.Launchers.Find(id);
        return launch;
    }

    public Launcher UpdateLauncher(Launcher update)
    {
        _tekkenContext.Launchers.Update(update);
        _tekkenContext.SaveChanges();
        return update;
    }
}
