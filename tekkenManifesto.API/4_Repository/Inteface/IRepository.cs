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
    
}