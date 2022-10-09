using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.TelephoneDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface ITelephoneService
{
    List<Telephone> Get();

    List<Telephone> Get(SortTelephoneDTO model);

    Telephone Get(int id);

    void Create(CreateTelephoneDTO model);

    void Edit(EditTelephoneDTO model);

    void Delete(DeleteBasicDTO model);
}