using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.WasherDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface IWasherService
{
    IEnumerable<Washer> Get();

    IQueryable<Washer> Get(SortWasherDTO model);

    Washer Get(int id);

    void Create(CreateWasherDTO model);

    void Edit(int id, EditWasherDTO model);

    void Delete(DeleteBasicDTO model);
}