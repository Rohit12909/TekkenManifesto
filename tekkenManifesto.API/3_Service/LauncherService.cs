using tekkenManifesto.API.Model;
using tekkenManifesto.API.Repository;

namespace tekkenManifesto.API.Service;

public class LauncherService : ILauncherService
{
    private readonly ILauncherRepository _launcherRepository;

    public LauncherService(ILauncherRepository launcherRepository)
    {
        _launcherRepository = launcherRepository;
    }

    public Launcher? CreateLauncher(Launcher c)
    {
        return _launcherRepository.CreateLauncher(c);
    }

    public Launcher? DeleteLauncher(int id)
    {
        var deleted = _launcherRepository.DeleteLauncher(_launcherRepository.GetLauncherById(id));
        return deleted;
    }

    public IEnumerable<Launcher> GetAllLaunchers()
    {
        var launcherList = _launcherRepository.GetAllLaunchers();
        return launcherList;
    }

    public Launcher UpdateLauncher(Launcher update, int id)
    {
        var updated = _launcherRepository.GetLauncherById(id);

        if (!string.IsNullOrWhiteSpace(update.Input))
        {
            updated.Input = update.Input;
        }

        if (!string.IsNullOrWhiteSpace(update.FramesOB))
        {
            updated.FramesOB = update.FramesOB;
        }

        updated = _launcherRepository.UpdateLauncher(updated);

        return updated;
    }
}
