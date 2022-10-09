using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.WasherDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface IWasherService
{
    List<Washer> Get();

    List<Washer> Get(SortWasherDTO model);

    Washer Get(int id);

    void Create(CreateWasherDTO model);

    void Edit(EditWasherDTO model);

    void Delete(DeleteBasicDTO model);
}