using tekkenManifesto.API.Model;
using tekkenManifesto.API.Repository;

namespace tekkenManifesto.API.Service;

public class ComboService : IComboService
{
    private readonly IComboRepository _comboRepository;
    private readonly ICharRepository _charRepository;

    public ComboService(IComboRepository comboRepository, ICharRepository charRepository)
    {
        _comboRepository = comboRepository;
        _charRepository = charRepository;
    }

    // WORK ON THIS
    public Combo? CreateNewCombo(Combo c, string name) 
    {
        var chars = _charRepository.GetCharByName(name);
        bool comboExists = false;

        foreach (Combo text in chars.Combos)
        {
            if (!text.TextNotation.Equals(c.TextNotation))
            {
                comboExists = false;
            }
            else
            {
                comboExists = true;
                break;
            }
        }

        if (!comboExists)
        {
            chars.Combos.Add(c);
        }
        else
        {
            throw new Exception("This combo already exists!");
        }
        
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