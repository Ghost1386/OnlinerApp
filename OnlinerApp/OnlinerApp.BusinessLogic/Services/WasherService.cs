using AutoMapper;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.WasherDTO;
using OnlinerApp.Model;
using OnlinerApp.Model.Models;

namespace OnlinerApp.BusinessLogic.Services;

public class WasherService : IWasherService
{
    private readonly ApplicationContext _context;
    private readonly IMapper _mapper;
    private readonly ISortService _sortService;

    public WasherService(ApplicationContext context, IMapper mapper, ISortService sortService)
    {
        _context = context;
        _mapper = mapper;
        _sortService = sortService;
    }

    public IEnumerable<Washer> Get()
    {
        return _context.Washers;
    }

    public IQueryable<Washer> Get(SortWasherDTO model)
    {
        var basicModel = new List<BasicModel>();
        
        basicModel.AddRange(_context.Washers);

        var sortedModels = _sortService.Sort(basicModel.AsQueryable(), model);

        var sortedWashers = sortedModels.Cast<Washer>();

        if (sortedWashers.ToList().Count == 0)
        {
            return null!;
        }
        
        var computer = SortByWasherModel(sortedWashers, model);

        if (computer.ToList().Count == 0)
        {
            return new List<Washer>().AsQueryable();
        }

        return computer;
    }

    private IQueryable<Washer> SortByWasherModel(IQueryable<Washer> query, SortWasherDTO model)
    {
        if (!string.IsNullOrEmpty(model.TypeOf))
        {
            query = query.Where(item => item.TypeOf == model.TypeOf);
        }
        
        if (model.Loading != 0)
        {
            query = query.Where(item => item.Loading == model.Loading);
        }
        
        query = query.Where(item => item.DownloadMethod == (int) model.DownloadMethod);
        
        if (model.SpinSpeed != 0)
        {
            query = query.Where(item => item.SpinSpeed == model.SpinSpeed);
        }
        
        if (!string.IsNullOrEmpty(model.EnergyConsumption))
        {
            query = query.Where(item => item.EnergyConsumption == model.EnergyConsumption);
        }
        
        query = query.Where(item => item.SteamTreatment == (int) model.SteamTreatment);
        
        if (model.NumberOfPrograms != 0)
        {
            query = query.Where(item => item.NumberOfPrograms == model.NumberOfPrograms);
        }
        
        return query;
    }

    public Washer Get(int id)
    {
        return _context.Washers.Where(x => x.Id == id).FirstOrDefault();
    }

    public void Create(CreateWasherDTO model)
    {
        var washer = _mapper.Map<CreateWasherDTO, Washer>(model);

        _context.Washers.Add(washer);
        _context.SaveChanges();
    }

    public void Edit(int id, EditWasherDTO model)
    {
        var washer = Get(id);

        if (washer.Id == 0)
        {
            return;
        }
        
        var editWasher = _mapper.Map<EditWasherDTO, Washer>(model);

        _context.Washers.Update(editWasher);
        _context.SaveChanges();
    }

    public void Delete(DeleteBasicDTO model)
    {
        _context.Washers.Remove(Get(model.Id));
        _context.SaveChanges();
    }
}