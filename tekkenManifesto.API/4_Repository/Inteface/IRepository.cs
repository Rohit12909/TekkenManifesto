using tekkenManifesto.API.Model;

namespace tekkenManifesto.API.Repository;

public interface ICharRepository
{
    Character CreateNewChar(Character newChar);
    Character? DeleteChar(Character chars);
    Character GetCharById(int id);
    IEnumerable<Character> GetAllChars();
}

public interface IComboRepository
{
    
}