using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.FridgeDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface IFridgeService
{
    IEnumerable<Fridge> Get();

    IQueryable<Fridge> Get(SortFridgeDTO model);

    Fridge Get(int id);

    void Create(CreateFridgeDTO model);

    void Edit(int id, EditFridgeDTO model);

    void Delete(DeleteBasicDTO model);
}