using AutoMapper;
using tekkenManifesto.API.DTO;
using tekkenManifesto.API.Model;
using tekkenManifesto.API.Repository;

namespace tekkenManifesto.API.Service;

public class CharService : ICharService
{
    private readonly ICharRepository _charRepository;
    private readonly IMapper _mapper;

    public CharService(ICharRepository charRepository, IMapper mapper)
    {
        _charRepository = charRepository;
        _mapper = mapper;
    }

    public CharOutDTO? CreateNewChar(CharInDTO newChar)
    {
        return _mapper.Map<CharOutDTO>(_charRepository.CreateNewChar(_mapper.Map<Character>(newChar)));
    }

    public CharOutDTO? DeleteChar(string name)
    {
        var deletedChar = _charRepository.DeleteChar(_charRepository.GetCharByName(name));
        return _mapper.Map<CharOutDTO>(deletedChar);
    }

    public IEnumerable<CharOutDTO> GetAllChars()
    {
        var charList = _charRepository.GetAllChars();
        return _mapper.Map<List<CharOutDTO>>(charList);
    }

    public CharOutDTO GetCharByName(string name)
    {
        var charList = _charRepository.GetCharByName(name);
        return _mapper.Map<CharOutDTO>(charList);
    }

    public CharOutDTO UpdateChar(CharInDTO update, int id)
    {
        var updated = _charRepository.GetCharById(id);

        if (!string.IsNullOrWhiteSpace(update.Name))
        {
            updated.Name = update.Name;
        }

        if (!string.IsNullOrWhiteSpace(update.ImageURL))
        {
            updated.ImageURL = update.ImageURL;
        }

        if (!string.IsNullOrWhiteSpace(update.Origin))
        {
            updated.Origin = update.Origin;
        }

        if (!string.IsNullOrWhiteSpace(update.FightingStyle))
        {
            updated.FightingStyle = update.FightingStyle;
        }
        
        if (!string.IsNullOrWhiteSpace(update.History))
        {
            updated.History = update.History;
        }

        if (!string.IsNullOrWhiteSpace(update.HighestRank))
        {
            updated.HighestRank = update.HighestRank;
        }
        
        if (updated.Played is true || update.Played is true)
        {
            updated.Played = true;
        }
        else
        {
            updated.Played = false;
        }

        updated = _charRepository.UpdateChar(updated);

        return _mapper.Map<CharOutDTO>(updated);
    }
}