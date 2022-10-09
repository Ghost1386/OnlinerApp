using AutoMapper;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.FridgeDTO;
using OnlinerApp.Model;
using OnlinerApp.Model.Models;

namespace OnlinerApp.BusinessLogic.Services;

public class FridgeService : IFridgeService
{
    private readonly ApplicationContext _context;
    private readonly IMapper _mapper;
    private readonly ISortService _sortService;

    public FridgeService(ApplicationContext context, IMapper mapper, ISortService sortService)
    {
        _context = context;
        _mapper = mapper;
        _sortService = sortService;
    }

    public IEnumerable<Fridge> Get()
    {
        return _context.Fridges;
    }

    public IQueryable<Fridge> Get(SortFridgeDTO model)
    {
        var basicModel = new List<BasicModel>();
        
        basicModel.AddRange(_context.Fridges);

        var sortedModels = _sortService.Sort(basicModel.AsQueryable(), model);

        var sortedFridges = sortedModels.Cast<Fridge>();

        if (sortedFridges.ToList().Count == 0)
        {
            return null!;
        }
        
        var fridge = SortByFridgeModel(sortedFridges, model);

        if (fridge.ToList().Count == 0)
        {
            return new List<Fridge>().AsQueryable();
        }

        return fridge;
    }

    private IQueryable<Fridge> SortByFridgeModel(IQueryable<Fridge> query, SortFridgeDTO model)
    {
        query = query.Where(item => item.Execution == (int) model.Execution);

        if (model.Height != 0)
        {
            query = query.Where(item => item.Height == model.Height);
        }
        
        if (model.Width != 0)
        {
            query = query.Where(item => item.Width == model.Width);
        }

        if (!string.IsNullOrEmpty(model.EnergyClass))
        {
            query = query.Where(item => item.EnergyClass == model.EnergyClass);
        }
        
        if (!string.IsNullOrEmpty(model.Modes))
        {
            query = query.Where(item => item.Modes == model.Modes);
        }
        
        if (!string.IsNullOrEmpty(model.Peculiarities))
        {
            query = query.Where(item => item.Peculiarities == model.Peculiarities);
        }

        return query;
    }

    public Fridge Get(int id)
    {
        return _context.Fridges.Where(x => x.Id == id).FirstOrDefault();
    }

    public void Create(CreateFridgeDTO model)
    {
        var fridge = _mapper.Map<CreateFridgeDTO, Fridge>(model);

        _context.Fridges.Add(fridge);
        _context.SaveChanges();
    }

    public void Edit(int id, EditFridgeDTO model)
    {
        var fridge = Get(id);

        if (fridge.Id == 0)
        {
            return;
        }
        
        var editFridge = _mapper.Map<EditFridgeDTO, Fridge>(model);

        _context.Fridges.Update(editFridge);
        _context.SaveChanges();
    }

    public void Delete(DeleteBasicDTO model)
    {
        _context.Fridges.Remove(Get(model.Id));
        _context.SaveChanges();
    }
}