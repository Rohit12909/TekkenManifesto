using tekkenManifesto.API.DTO;
using tekkenManifesto.API.Model;

namespace tekkenManifesto.API.Service;

public interface ICharService
{
    CharOutDTO? CreateNewChar(CharInDTO newChar);
    CharOutDTO? DeleteChar(int id);
    IEnumerable<CharOutDTO> GetAllChars();
}

public interface IComboService
{

}