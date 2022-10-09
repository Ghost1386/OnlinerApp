using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.TelevisionDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface ITelevisionService
{
    List<Television> Get();

    List<Television> Get(SortTelevisionDTO model);

    Television Get(int id);

    void Create(CreateTelevisionDTO model);

    void Edit(EditTelevisionDTO model);

    void Delete(DeleteBasicDTO model);
}