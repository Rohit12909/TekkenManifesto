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

    public CharOutDTO? DeleteChar(int id)
    {
        var deletedChar = _charRepository.DeleteChar(_charRepository.GetCharById(id));
        return _mapper.Map<CharOutDTO>(deletedChar);
    }

    public IEnumerable<CharOutDTO> GetAllChars()
    {
        var charList = _charRepository.GetAllChars();
        return _mapper.Map<List<CharOutDTO>>(charList);
    }
}