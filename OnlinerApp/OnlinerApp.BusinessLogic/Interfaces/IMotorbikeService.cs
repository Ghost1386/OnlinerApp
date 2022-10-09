using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.MotorbikeDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface IMotorbikeService
{
    IEnumerable<Motorbike> Get();

    IQueryable<Motorbike> Get(SortMotorbikeDTO model);

    Motorbike Get(int id);

    void Create(CreateMotorbikeDTO model);

    void Edit(int id, EditMotorbikeDTO model);

    void Delete(DeleteBasicDTO model);
}