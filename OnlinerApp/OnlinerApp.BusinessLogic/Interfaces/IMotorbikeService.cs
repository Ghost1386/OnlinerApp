using OnlinerApp.Model.Models;
using OnlinerApp.Common.DTO_s.MotorbikeDTO;
using OnlinerApp.Common.DTO_s.DeleteDTO;

namespace OnlinerApp.BusinessLogic.Interfaces;

public interface IMotorbikeService
{
    List<Motorbike> Get();

    List<Motorbike> Get(SortMotorbikeDTO model);

    Motorbike Get(int id);

    void Create(CreateMotorbikeDTO model);

    void Edit(EditMotorbikeDTO model);

    void Delete(DeleteBasicDTO model);
}