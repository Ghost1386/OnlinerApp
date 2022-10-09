using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.MicrowaveDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface IMicrowaveService
{
    IEnumerable<Microwave> Get();

    IQueryable<Microwave> Get(SortMicrowaveDTO model);

    Microwave Get(int id);

    void Create(CreateMicrowaveDTO model);

    void Edit(int id, EditMicrowaveDTO model);

    void Delete(DeleteBasicDTO model);
}