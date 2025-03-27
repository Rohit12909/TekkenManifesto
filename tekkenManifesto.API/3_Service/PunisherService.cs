using tekkenManifesto.API.Model;
using tekkenManifesto.API.Repository;

namespace tekkenManifesto.API.Service;

public class PunisherService : IPunisherService
{
    private readonly IPunisherRepository _punisherRepository;

    public PunisherService(IPunisherRepository punisherRepository)
    {
        _punisherRepository = punisherRepository;
    }

    public Punisher? CreatePunisher(Punisher c)
    {
        return _punisherRepository.CreatePunisher(c);
    }

    public Punisher? DeletePunisher(int id)
    {
        var deleted = _punisherRepository.DeletePunisher(_punisherRepository.GetPunisherById(id));
        return deleted;
    }

    public IEnumerable<Punisher> GetAllPunishers()
    {
        var punishList = _punisherRepository.GetAllPunishers();
        return punishList;
    }

    public Punisher UpdatePunisher(Punisher update, int id)
    {
        var updated = _punisherRepository.GetPunisherById(id);

        if (!string.IsNullOrWhiteSpace(update.Input))
        {
            updated.Input = update.Input;
        }

        if (!string.IsNullOrWhiteSpace(update.EnemyIs))
        {
            updated.EnemyIs = update.EnemyIs;
        }

        updated = _punisherRepository.UpdatePunisher(updated);

        return updated;
    }
}
