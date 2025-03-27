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
    Combo GetComboById(int id);
    Combo UpdateCombo(Combo update);
    Combo? DeleteCombo(Combo com);
}

public interface IHERepository
{
    HeatEngager? CreateNewHE(HeatEngager c);
    IEnumerable<HeatEngager> GetAllHE();
    HeatEngager GetHEById(int id);
    HeatEngager UpdateHE(HeatEngager update);
    HeatEngager? DeleteHE(HeatEngager he);
}

public interface ILauncherRepository
{
    Launcher? CreateLauncher(Launcher c);
    IEnumerable<Launcher> GetAllLaunchers();
    Launcher GetLauncherById(int id);
    Launcher UpdateLauncher(Launcher update);
    Launcher? DeleteLauncher(Launcher launch);
}

public interface IPunisherRepository
{
    Punisher? CreatePunisher(Punisher c);
    IEnumerable<Punisher> GetAllPunishers();
    Punisher GetPunisherById(int id);
    Punisher UpdatePunisher(Punisher update);
    Punisher? DeletePunisher(Punisher punish);
}

public interface IStanceRepository
{
    Stance? CreateStance(Stance c);
    IEnumerable<Stance> GetAllStances();
    Stance GetStanceById(int id);
    Stance UpdateStance(Stance update);
    Stance? DeleteStance(Stance stance);
}