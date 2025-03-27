using tekkenManifesto.API.Model;

namespace tekkenManifesto.API.Repository;

public interface ICharRepository
{
    Character CreateNewChar(Character newChar);
    Character? DeleteChar(Character chars);
    Character GetCharById(int id);
    Character GetCharByName(string name);
    IEnumerable<Character> GetAllChars();
    Character UpdateChar(Character update);
}

public interface IComboRepository
{
    Combo? CreateNewCombo(Combo c);
    IEnumerable<Combo> GetAllCombos();
    Combo UpdateCombo(Combo update, int id);
    Combo? DeleteCombo(int id);
}

public interface IHERepository
{
    HeatEngager? CreateNewHE(HeatEngager c);
    IEnumerable<HeatEngager> GetAllHE();
    HeatEngager UpdateHE(HeatEngager update, int id);
    HeatEngager? DeleteHE(int id);
}

public interface ILauncherRepository
{
    Launcher? CreateLauncher(Launcher c);
    IEnumerable<Launcher> GetAllLaunchers();
    Launcher UpdateLauncher(Launcher update, int id);
    Launcher? DeleteLauncher(int id);
}

public interface IPunisherRepository
{
    Punisher? CreatePunisher(Punisher c);
    IEnumerable<Punisher> GetAllPunishers();
    Punisher UpdatePunisher(Punisher update, int id);
    Punisher? DeletePunisher(int id);
}

public interface IStanceRepository
{
    Stance? CreateStance(Stance c);
    IEnumerable<Stance> GetAllStances();
    Stance UpdateStance(Stance update, int id);
    Stance? DeleteStance(int id);
}