using tekkenManifesto.API.Model;
using tekkenManifesto.API.Repository;

namespace tekkenManifesto.API.Service;

public class PunisherService : IPunisherService
{
    private readonly IPunisherRepository _punisherRepository;
    private readonly ICharRepository _charRepository;

    public PunisherService(IPunisherRepository punisherRepository, ICharRepository charRepository)
    {
        _punisherRepository = punisherRepository;
        _charRepository = charRepository;
    }

    public Punisher? CreatePunisher(Punisher p, string name)
    {
        var chars = _charRepository.GetCharByName(name);
        bool punishExists = false;

        foreach (Punisher pun in chars.Punishers)
        {
            if (!pun.Input.Equals(p.Input))
            {
                punishExists = false;
            }
            else
            {
                punishExists = true;
                break;
            }
        }

        if (!punishExists)
        {
            chars.Punishers.Add(p);
        }
        else
        {
            throw new Exception("This punisher already exists!");
        }
        return _punisherRepository.CreatePunisher(p);
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
