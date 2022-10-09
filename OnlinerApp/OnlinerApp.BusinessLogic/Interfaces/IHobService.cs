using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.HobDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface IHobService
{
    IEnumerable<Hob> Get();

    IQueryable<Hob> Get(SortHobDTO model);

    Hob Get(int id);

    void Create(CreateHobDTO model);

    void Edit(int id, EditHobDTO model);

    void Delete(DeleteBasicDTO model);
}