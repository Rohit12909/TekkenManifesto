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

}