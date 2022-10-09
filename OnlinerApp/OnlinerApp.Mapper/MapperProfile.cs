using AutoMapper;
using OnlinerApp.Common.DTO_s.СomputerDTO;
using OnlinerApp.Model;
using OnlinerApp.Model.Models;

namespace OnlinerApp.Mapper;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<CreateСomputerDTO, Сomputer>();
    }
}