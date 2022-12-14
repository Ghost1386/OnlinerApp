using AutoMapper;
using OnlinerApp.Common.DTO_s.AuthDTO;
using OnlinerApp.Common.DTO_s.FridgeDTO;
using OnlinerApp.Common.DTO_s.HobDTO;
using OnlinerApp.Common.DTO_s.MicrowaveDTO;
using OnlinerApp.Common.DTO_s.MotorbikeDTO;
using OnlinerApp.Common.DTO_s.NotebookDTO;
using OnlinerApp.Common.DTO_s.TelephoneDTO;
using OnlinerApp.Common.DTO_s.TelevisionDTO;
using OnlinerApp.Common.DTO_s.UserDTO;
using OnlinerApp.Common.DTO_s.VacuumCleanerDTO;
using OnlinerApp.Common.DTO_s.WasherDTO;
using OnlinerApp.Common.DTO_s.СomputerDTO;
using OnlinerApp.Model.Models;

namespace OnlinerApp.Mapper;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<CreateСomputerDTO, Сomputer>();
        CreateMap<EditСomputerDTO, Сomputer>();
        
        CreateMap<CreateFridgeDTO, Fridge>();
        CreateMap<EditFridgeDTO, Fridge>();
        
        CreateMap<CreateHobDTO, Hob>();
        CreateMap<EditHobDTO, Hob>();
        
        CreateMap<CreateMicrowaveDTO, Microwave>();
        CreateMap<EditMicrowaveDTO, Microwave>();
        
        CreateMap<CreateMotorbikeDTO, Motorbike>();
        CreateMap<EditMotorbikeDTO, Motorbike>();
        
        CreateMap<CreateNotebookDTO, Notebook>();
        CreateMap<EditNotebookDTO, Notebook>();
        
        CreateMap<CreateTelephoneDTO, Telephone>();
        CreateMap<EditTelephoneDTO, Telephone>();
        
        CreateMap<CreateTelevisionDTO, Television>();
        CreateMap<EditTelevisionDTO, Television>();
        
        CreateMap<CreateVacuumCleanerDTO, VacuumCleaner>();
        CreateMap<EditVacuumCleanerDTO, VacuumCleaner>();
        
        CreateMap<CreateWasherDTO, Washer>();
        CreateMap<EditWasherDTO, Washer>();
        
        CreateMap<CreateUserDTO, User>();
        CreateMap<EditUserDTO, User>();
        
        CreateMap<RegisterUserDTO, CreateUserDTO>();
        CreateMap<EditUserDTO, User>();
    }
}