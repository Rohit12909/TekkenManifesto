using tekkenManifesto.API.DTO;
using tekkenManifesto.API.Model;

namespace tekkenManifesto.API.Service;

public interface ICharService
{
    CharOutDTO? CreateNewChar(CharInDTO newChar);
    IEnumerable<CharOutDTO> GetAllChars();
    CharOutDTO UpdateChar(CharInDTO update, int id);
    CharOutDTO? DeleteChar(int id);
    
}

public interface IComboService
{
    // Combos
    Combo? CreateNewCombo(Combo c);
    IEnumerable<Combo> GetAllCombos();
    Combo UpdateCombo(Combo update, int id);
    Combo? DeleteCombo(int id);

    // Heat Engagers
    Combo? CreateNewHE(Combo c);
    IEnumerable<Combo> GetAllHE();
    Combo UpdateHE(Combo update, int id);
    Combo? DeleteHE(int id);

    // Launchers
    Combo? CreateLauncher(Combo c);
    IEnumerable<Combo> GetAllLaunchers();
    Combo UpdateLauncher(Combo update, int id);
    Combo? DeleteLauncher(int id);

    // Stances
    Combo? CreateStance(Combo c);
    IEnumerable<Combo> GetAllStances();
    Combo UpdateStance(Combo update, int id);
    Combo? DeleteStance(int id);

    // Punishers
    Combo? CreatePunisher(Combo c);
    IEnumerable<Combo> GetAllPunishers();
    Combo UpdatePunisher(Combo update, int id);
    Combo? DeletePunisher(int id);
}