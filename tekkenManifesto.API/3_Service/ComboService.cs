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

    public Combo? CreateLauncher(Combo c)
    {
        throw new NotImplementedException();
    }

    public Combo? CreateNewCombo(Combo c)
    {
        throw new NotImplementedException();
    }

    public Combo? CreateNewHE(Combo c)
    {
        throw new NotImplementedException();
    }

    public Combo? CreatePunisher(Combo c)
    {
        throw new NotImplementedException();
    }

    public Combo? CreateStance(Combo c)
    {
        throw new NotImplementedException();
    }

    public Combo? DeleteCombo(int id)
    {
        throw new NotImplementedException();
    }

    public Combo? DeleteHE(int id)
    {
        throw new NotImplementedException();
    }

    public Combo? DeleteLauncher(int id)
    {
        throw new NotImplementedException();
    }

    public Combo? DeletePunisher(int id)
    {
        throw new NotImplementedException();
    }

    public Combo? DeleteStance(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Combo> GetAllCombos()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Combo> GetAllHE()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Combo> GetAllLaunchers()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Combo> GetAllPunishers()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Combo> GetAllStances()
    {
        throw new NotImplementedException();
    }

    public Combo UpdateCombo(Combo update, int id)
    {
        throw new NotImplementedException();
    }

    public Combo UpdateHE(Combo update, int id)
    {
        throw new NotImplementedException();
    }

    public Combo UpdateLauncher(Combo update, int id)
    {
        throw new NotImplementedException();
    }

    public Combo UpdatePunisher(Combo update, int id)
    {
        throw new NotImplementedException();
    }

    public Combo UpdateStance(Combo update, int id)
    {
        throw new NotImplementedException();
    }
}