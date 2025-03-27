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

}

public interface IHEService
{
    // Heat Engagers
    HeatEngager? CreateNewHE(HeatEngager c);
    IEnumerable<HeatEngager> GetAllHE();
    HeatEngager UpdateHE(HeatEngager update, int id);
    HeatEngager? DeleteHE(int id);
}

public interface ILauncherService
{
    // Launchers
    Launcher? CreateLauncher(Launcher c);
    IEnumerable<Launcher> GetAllLaunchers();
    Launcher UpdateLauncher(Launcher update, int id);
    Launcher? DeleteLauncher(int id);
}

public interface IPunisherService
{
    // Punishers
    Punisher? CreatePunisher(Punisher c);
    IEnumerable<Punisher> GetAllPunishers();
    Punisher UpdatePunisher(Punisher update, int id);
    Punisher? DeletePunisher(int id);
}

public interface IStanceService
{
    // Stances
    Stance? CreateStance(Stance c);
    IEnumerable<Stance> GetAllStances();
    Stance UpdateStance(Stance update, int id);
    Stance? DeleteStance(int id);
}