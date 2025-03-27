using tekkenManifesto.API.Model;
using tekkenManifesto.API.Repository;

namespace tekkenManifesto.API.Service;

public class ComboService : IComboService
{
    private readonly IComboRepository _comboRepository;

    public ComboService(IComboRepository comboRepository)
    {
        _comboRepository = comboRepository;
    }

    public Combo? CreateNewCombo(Combo c)
    {
        return _comboRepository.CreateNewCombo(c);
    }

    public Combo? DeleteCombo(int id)
    {
        var deleted = _comboRepository.DeleteCombo(_comboRepository.GetComboById(id));
        return deleted;
    }

    public IEnumerable<Combo> GetAllCombos()
    {
        var comboList = _comboRepository.GetAllCombos();
        return comboList;
    }

    public Combo UpdateCombo(Combo update, int id)
    {
        var updated = _comboRepository.GetComboById(id);

        if (!string.IsNullOrWhiteSpace(update.TextNotation))
        {
            updated.TextNotation = update.TextNotation;
        }

        if (!string.IsNullOrWhiteSpace(update.VisualNotationURL))
        {
            updated.VisualNotationURL = update.VisualNotationURL;
        }

        if (!string.IsNullOrWhiteSpace(update.Damage.ToString()))
        {
            updated.Damage = update.Damage;
        }

        updated = _comboRepository.UpdateCombo(updated);

        return updated;
    }
}