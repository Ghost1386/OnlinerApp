using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.TelevisionDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface ITelevisionService
{
    IEnumerable<Television> Get();

    IQueryable<Television> Get(SortTelevisionDTO model);

    Television Get(int id);

    void Create(CreateTelevisionDTO model);

    void Edit(int id, EditTelevisionDTO model);

    void Delete(DeleteBasicDTO model);
}