using tekkenManifesto.API.Model;
using tekkenManifesto.API.Repository;

namespace tekkenManifesto.API.Service;

public class LauncherService : ILauncherService
{
    private readonly ILauncherRepository _launcherRepository;
    private readonly ICharRepository _charRepository;

    public LauncherService(ILauncherRepository launcherRepository, ICharRepository charRepository)
    {
        _launcherRepository = launcherRepository;
        _charRepository = charRepository;
    }

    public Launcher? CreateLauncher(Launcher launch, string name)
    {
        var chars = _charRepository.GetCharByName(name);
        bool launcherExists = false;

        foreach (Launcher l in chars.Launchers)
        {
            if (!l.Input.Equals(launch.Input))
            {
                launcherExists = false;
            }
            else
            {
                launcherExists = true;
                break;
            }
        }

        if (!launcherExists)
        {
            chars.Launchers.Add(launch);
        }
        else
        {
            throw new Exception("This launcher already exists!");
        }
        return _launcherRepository.CreateLauncher(launch);
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
