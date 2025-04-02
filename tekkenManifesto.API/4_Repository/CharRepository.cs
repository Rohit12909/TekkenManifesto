using Microsoft.EntityFrameworkCore;
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
        var chars = _tekkenContext.Chars.Find(id);
        return chars;
    }

    public Character GetCharByName(string name)
    {
        var chars = _tekkenContext.Chars
            .Include(c => c.Combos)
            .Include(h => h.HeatEngagers)
            .Include(l => l.Launchers)
            .Include(p => p.Punishers)
            .Include(s => s.Stances)
            .Where(c => c.Name == name).First();
        return chars;
    }

    public Character UpdateChar(Character update)
    {
        _tekkenContext.Chars.Update(update);
        _tekkenContext.SaveChanges();
        return update;
    }
}