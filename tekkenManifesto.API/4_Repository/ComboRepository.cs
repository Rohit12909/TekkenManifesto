using tekkenManifesto.API.Data;
using tekkenManifesto.API.Model;

namespace tekkenManifesto.API.Repository;

public class ComboRepository : IComboRepository
{
    private readonly TekkenContext _tekkenContext;

    public ComboRepository(TekkenContext tekkenContext)
    {
        _tekkenContext = tekkenContext;
    }

    public Combo? CreateNewCombo(Combo c)
    {
        _tekkenContext.Combos.Add(c);
        _tekkenContext.SaveChanges();
        return c;
    }

    public Combo? DeleteCombo(Combo com)
    {
        _tekkenContext.Combos.Remove(com);
        _tekkenContext.SaveChanges();
        return com;
    }

    public IEnumerable<Combo> GetAllCombos()
    {
        return _tekkenContext.Combos.ToList();
    }

    public Combo GetComboById(int id)
    {
        var coms = _tekkenContext.Combos.Find(id);
        return coms;
    }

    public Combo UpdateCombo(Combo update)
    {
        _tekkenContext.Combos.Update(update);
        _tekkenContext.SaveChanges();
        return update;
    }
}