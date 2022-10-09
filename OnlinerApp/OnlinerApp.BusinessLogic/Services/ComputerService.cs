using AutoMapper;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.СomputerDTO;
using OnlinerApp.Model;
using OnlinerApp.Model.Models;

namespace OnlinerApp.BusinessLogic.Services;

public class ComputerService : IComputerService
{
    private readonly ApplicationContext _context;
    private readonly IMapper _mapper;
    private readonly ISortService _sortService;

    public ComputerService(ApplicationContext context, IMapper mapper, ISortService sortService)
    {
        _context = context;
        _mapper = mapper;
        _sortService = sortService;
    }

    public IEnumerable<Сomputer> Get()
    {
        return _context.Сomputers;
    }

    public IQueryable<Сomputer> Get(SortСomputerDTO model)
    {
        var basicModel = new List<BasicModel>();
        
        basicModel.AddRange(_context.Сomputers);

        var sortedModels = _sortService.Sort(basicModel.AsQueryable(), model);

        var sortedComputers = sortedModels.Cast<Сomputer>();

        if (sortedComputers.ToList().Count == 0)
        {
            return null!;
        }
        
        var computer = SortByComputerModel(sortedComputers, model);

        if (computer.ToList().Count == 0)
        {
            return new List<Сomputer>().AsQueryable();
        }

        return computer;
    }

    private IQueryable<Сomputer> SortByComputerModel(IQueryable<Сomputer> query, SortСomputerDTO model)
    {
        if (!string.IsNullOrEmpty(model.Cpu))
        {
            query = query.Where(item => item.Cpu == model.Cpu);
        }

        if (!string.IsNullOrEmpty(model.VideoCard))
        {
            query = query.Where(item => item.VideoCard == model.VideoCard);
        }

        query = query.Where(item => item.Hdd == (int) model.Hdd);

        if (model.HardDiskCapacity != 0)
        {
            query = query.Where(item => item.HardDiskCapacity == model.HardDiskCapacity);
        }
        
        query = query.Where(item => item.Ram == (int) model.Ram);
        
        if (model.RamCapacity != 0)
        {
            query = query.Where(item => item.RamCapacity == model.RamCapacity);
        }
        
        query = query.Where(item => item.ComputerType == (int) model.ComputerType);
        
        if (model.PowerSupply != 0)
        {
            query = query.Where(item => item.PowerSupply == model.PowerSupply);
        }
        
        query = query.Where(item => item.OperatingSystem == (int) model.OperatingSystem);

        return query;
    }

    public Сomputer Get(int id)
    {
        return _context.Сomputers.Where(x => x.Id == id).FirstOrDefault();
    }

    public void Create(CreateСomputerDTO model)
    {
        var computer = _mapper.Map<CreateСomputerDTO, Сomputer>(model);

        _context.Сomputers.Add(computer);
        _context.SaveChanges();
    }

    public void Edit(int id, EditСomputerDTO model)
    {
        var computer = Get(id);

        if (computer == null)
        {
            return;
        }
        
        var editComputer = _mapper.Map<EditСomputerDTO, Сomputer>(model);

        _context.Сomputers.Update(editComputer);
        _context.SaveChanges();
    }

    public void Delete(DeleteBasicDTO model)
    {
        _context.Сomputers.Remove(Get(model.Id));
        _context.SaveChanges();
    }
}