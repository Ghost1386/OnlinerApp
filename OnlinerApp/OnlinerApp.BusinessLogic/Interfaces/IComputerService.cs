using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.СomputerDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface IComputerService
{
    IEnumerable<Сomputer> Get();

    IQueryable<Сomputer> Get(SortСomputerDTO model);

    Сomputer Get(int id);

    void Create(CreateСomputerDTO model);

    void Edit(int id, EditСomputerDTO model);

    void Delete(DeleteBasicDTO model);
}