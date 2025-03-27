using tekkenManifesto.API.Model;
using tekkenManifesto.API.Repository;

namespace tekkenManifesto.API.Service;

public class HeatEngagerService : IHEService
{
    private readonly IHERepository _heRepository;

    public HeatEngagerService(IHERepository heRepository)
    {
        _heRepository = heRepository;
    }

    public HeatEngager? CreateNewHE(HeatEngager c)
    {
        return _heRepository.CreateNewHE(c);
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
