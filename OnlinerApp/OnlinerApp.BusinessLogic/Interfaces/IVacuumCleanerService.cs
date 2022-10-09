using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.VacuumCleanerDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface IVacuumCleanerService
{
    IEnumerable<VacuumCleaner> Get();

    IQueryable<VacuumCleaner> Get(SortVacuumCleanerDTO model);

    VacuumCleaner Get(int id);

    void Create(CreateVacuumCleanerDTO model);

    void Edit(int id, EditVacuumCleanerDTO model);

    void Delete(DeleteBasicDTO model);
}