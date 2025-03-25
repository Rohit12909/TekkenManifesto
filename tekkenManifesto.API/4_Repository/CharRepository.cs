using tekkenManifesto.API.Data;
using tekkenManifesto.API.Model;

namespace tekkenManifesto.API.Repository;

public class CharRepository : ICharRepository
{
    private readonly TekkenContext _tekkenContext;

    public CharRepository(TekkenContext tekkenContext)
    {
        _tekkenContext = tekkenContext;
    }

    public Character CreateNewChar(Character newChar)
    {
        _tekkenContext.Chars.Add(newChar);
        _tekkenContext.SaveChanges();
        return newChar;
    }

    public Character? DeleteChar(Character chars)
    {
        _tekkenContext.Chars.Remove(chars);
        _tekkenContext.SaveChanges();
        return chars;
    }

    public IEnumerable<Character> GetAllChars()
    {
        return _tekkenContext.Chars.ToList();
    }

    public Character GetCharById(int id)
    {
        Character chars = _tekkenContext.Chars.Find(id);
        return chars;
    }
}