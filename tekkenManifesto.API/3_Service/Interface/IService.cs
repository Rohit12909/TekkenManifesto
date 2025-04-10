using tekkenManifesto.API.DTO;
using tekkenManifesto.API.Model;

namespace tekkenManifesto.API.Service;

public interface ICharService
{
    CharOutDTO? CreateNewChar(CharInDTO newChar);
    IEnumerable<CharOutDTO> GetAllChars();
    CharOutDTO? GetCharByName(string name);
    
    CharOutDTO UpdateChar(CharInDTO update, int id);
    CharOutDTO? DeleteChar(string name);
    
}

public interface IComboService
{
    // Combos
    Combo? CreateNewCombo(Combo c, string name);
    IEnumerable<Combo> GetAllCombos();
    Combo UpdateCombo(Combo update, int id);
    Combo? DeleteCombo(int id);

}

public interface IHEService
{
    // Heat Engagers
    HeatEngager? CreateNewHE(HeatEngager c, string name);
    IEnumerable<HeatEngager> GetAllHE();
    HeatEngager UpdateHE(HeatEngager update, int id);
    HeatEngager? DeleteHE(int id);
}

public interface ILauncherService
{
    // Launchers
    Launcher? CreateLauncher(Launcher c, string name);
    IEnumerable<Launcher> GetAllLaunchers();
    Launcher UpdateLauncher(Launcher update, int id);
    Launcher? DeleteLauncher(int id);
}

public interface IPunisherService
{
    // Punishers
    Punisher? CreatePunisher(Punisher c, string name);
    IEnumerable<Punisher> GetAllPunishers();
    Punisher UpdatePunisher(Punisher update, int id);
    Punisher? DeletePunisher(int id);
}

public interface IStanceService
{
    // Stances
    Stance? CreateStance(Stance c, string name);
    IEnumerable<Stance> GetAllStances();
    Stance UpdateStance(Stance update, int id);
    Stance? DeleteStance(int id);
}