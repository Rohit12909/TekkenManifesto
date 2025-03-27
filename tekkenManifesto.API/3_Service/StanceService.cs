using tekkenManifesto.API.Model;
using tekkenManifesto.API.Repository;

namespace tekkenManifesto.API.Service;

public class StanceService : IStanceService
{
    private readonly IStanceRepository _stanceRepository;

    public StanceService(IStanceRepository stanceRepository)
    {
        _stanceRepository = stanceRepository;
    }

    public Stance? CreateStance(Stance c)
    {
        return _stanceRepository.CreateStance(c);
    }

    public Stance? DeleteStance(int id)
    {
        var deleted = _stanceRepository.DeleteStance(_stanceRepository.GetStanceById(id));
        return deleted;
    }

    public IEnumerable<Stance> GetAllStances()
    {
        var stanceList = _stanceRepository.GetAllStances();
        return stanceList;
    }

    public Stance UpdateStance(Stance update, int id)
    {
        var updated = _stanceRepository.GetStanceById(id);
        
        if (!string.IsNullOrWhiteSpace(update.Name))
        {
            updated.Name = update.Name;
        }

        if (!string.IsNullOrWhiteSpace(update.Input))
        {
            updated.Input = update.Input;
        }

        updated = _stanceRepository.UpdateStance(updated);

        return updated;
    }
}
