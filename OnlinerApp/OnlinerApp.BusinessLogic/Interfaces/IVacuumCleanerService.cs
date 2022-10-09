using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.VacuumCleanerDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface IVacuumCleanerService
{
    List<VacuumCleaner> Get();

    List<VacuumCleaner> Get(SortVacuumCleanerDTO model);

    VacuumCleaner Get(int id);

    void Create(CreateVacuumCleanerDTO model);

    void Edit(EditVacuumCleanerDTO model);

    void Delete(DeleteBasicDTO model);
}