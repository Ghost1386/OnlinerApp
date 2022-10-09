using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.MicrowaveDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface IMicrowaveService
{
    List<Microwave> Get();

    List<Microwave> Get(SortMicrowaveDTO model);

    Microwave Get(int id);

    void Create(CreateMicrowaveDTO model);

    void Edit(EditMicrowaveDTO model);

    void Delete(DeleteBasicDTO model);
}