using AutoMapper;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.VacuumCleanerDTO;
using OnlinerApp.Model;
using OnlinerApp.Model.Models;

namespace OnlinerApp.BusinessLogic.Services;

public class VacuumCleanerService : IVacuumCleanerService
{
    private readonly ApplicationContext _context;
    private readonly IMapper _mapper;
    private readonly ISortService _sortService;

    public VacuumCleanerService(ApplicationContext context, IMapper mapper, ISortService sortService)
    {
        _context = context;
        _mapper = mapper;
        _sortService = sortService;
    }

    public IEnumerable<VacuumCleaner> Get()
    {
        return _context.VacuumCleaners;
    }

    public IQueryable<VacuumCleaner> Get(SortVacuumCleanerDTO model)
    {
        var basicModel = new List<BasicModel>();
        
        basicModel.AddRange(_context.VacuumCleaners);

        var sortedModels = _sortService.Sort(basicModel.AsQueryable(), model);

        var sortedVacuumCleaners = sortedModels.Cast<VacuumCleaner>();

        if (sortedVacuumCleaners.ToList().Count == 0)
        {
            return null!;
        }
        
        var vacuumCleaner = SortByVacuumCleanerModel(sortedVacuumCleaners, model);

        if (vacuumCleaner.ToList().Count == 0)
        {
            return new List<VacuumCleaner>().AsQueryable();
        }

        return vacuumCleaner;
    }

    private IQueryable<VacuumCleaner> SortByVacuumCleanerModel(IQueryable<VacuumCleaner> query,
        SortVacuumCleanerDTO model)
    {
        if (!string.IsNullOrEmpty(model.TypeOf))
        {
            query = query.Where(item => item.TypeOf == model.TypeOf);
        }
        
        if (!string.IsNullOrEmpty(model.Supply))
        {
            query = query.Where(item => item.Supply == model.Supply);
        }
        
        if (model.SuctionPower != 0)
        {
            query = query.Where(item => item.SuctionPower == model.SuctionPower);
        }
        
        query = query.Where(item => item.PowerAdjustment == (int) model.PowerAdjustment);
        
        query = query.Where(item => item.Pipe == (int) model.Pipe);
        
        return query;
    }

    public VacuumCleaner Get(int id)
    {
        return _context.VacuumCleaners.Where(x => x.Id == id).FirstOrDefault();
    }

    public void Create(CreateVacuumCleanerDTO model)
    {
        var vacuumCleaner = _mapper.Map<CreateVacuumCleanerDTO, VacuumCleaner>(model);

        _context.VacuumCleaners.Add(vacuumCleaner);
        _context.SaveChanges();
    }

    public void Edit(int id, EditVacuumCleanerDTO model)
    {
        var vacuumCleaner = Get(id);

        if (vacuumCleaner.Id == 0)
        {
            return;
        }
        
        var editVacuumCleaner = _mapper.Map<EditVacuumCleanerDTO, VacuumCleaner>(model);

        _context.VacuumCleaners.Update(editVacuumCleaner);
        _context.SaveChanges();
    }

    public void Delete(DeleteBasicDTO model)
    {
        _context.VacuumCleaners.Remove(Get(model.Id));
        _context.SaveChanges();
    }
}