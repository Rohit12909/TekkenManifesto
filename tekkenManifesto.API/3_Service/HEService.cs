using tekkenManifesto.API.Model;
using tekkenManifesto.API.Repository;

namespace tekkenManifesto.API.Service;

public class HeatEngagerService : IHEService
{
    private readonly IHERepository _heRepository;
    private readonly ICharRepository _charRepository;

    public HeatEngagerService(IHERepository heRepository, ICharRepository charRepository)
    {
        _heRepository = heRepository;
        _charRepository = charRepository;
    }

    public HeatEngager? CreateNewHE(HeatEngager h, string name)
    {
        var chars = _charRepository.GetCharByName(name);
        bool heExists = false;

        foreach (HeatEngager he in chars.HeatEngagers)
        {
            if (!he.Input.Equals(h.Input))
            {
                heExists = false;
            }
            else
            {
                heExists = true;
                break;
            }
        }

        if (!heExists)
        {
            chars.HeatEngagers.Add(h);
        }
        else
        {
            throw new Exception("This heat engager already exists!");
        }
        return _heRepository.CreateNewHE(h);
    }

    public HeatEngager? DeleteHE(int id)
    {
        var deleted = _heRepository.DeleteHE(_heRepository.GetHEById(id));
        return deleted;
    }

    public IEnumerable<HeatEngager> GetAllHE()
    {
        var heList = _heRepository.GetAllHE();
        return heList;
    }

    public HeatEngager UpdateHE(HeatEngager update, int id)
    {
        var updated = _heRepository.GetHEById(id);

        if (!string.IsNullOrWhiteSpace(update.Input))
        {
            updated.Input = update.Input;
        }

        if (!string.IsNullOrWhiteSpace(update.FramesOB))
        {
            updated.FramesOB = update.FramesOB;
        }

        updated = _heRepository.UpdateHE(updated);

        return updated;
    }
}
