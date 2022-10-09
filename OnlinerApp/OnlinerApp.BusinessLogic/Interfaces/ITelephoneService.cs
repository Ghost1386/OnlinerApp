using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.TelephoneDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface ITelephoneService
{
    IEnumerable<Telephone> Get();

    IQueryable<Telephone> Get(SortTelephoneDTO model);

    Telephone Get(int id);

    void Create(CreateTelephoneDTO model);

    void Edit(int id, EditTelephoneDTO model);

    void Delete(DeleteBasicDTO model);
}