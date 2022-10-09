using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.HobDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface IHobService
{
    List<Hob> Get();

    List<Hob> Get(SortHobDTO model);

    Hob Get(int id);

    void Create(CreateHobDTO model);

    void Edit(EditHobDTO model);

    void Delete(DeleteBasicDTO model);
}