using AutoMapper;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.MotorbikeDTO;
using OnlinerApp.Model;
using OnlinerApp.Model.Models;

namespace OnlinerApp.BusinessLogic.Services;

public class MotorbikeService : IMotorbikeService
{
    private readonly ApplicationContext _context;
    private readonly IMapper _mapper;
    private readonly ISortService _sortService;

    public MotorbikeService(ApplicationContext context, IMapper mapper, ISortService sortService)
    {
        _context = context;
        _mapper = mapper;
        _sortService = sortService;
    }

    public IEnumerable<Motorbike> Get()
    {
        return _context.Motorbikes;
    }

    public IQueryable<Motorbike> Get(SortMotorbikeDTO model)
    {
        var basicModel = new List<BasicModel>();
        
        basicModel.AddRange(_context.Motorbikes);

        var sortedModels = _sortService.Sort(basicModel.AsQueryable(), model);

        var sortedMotorbikes = sortedModels.Cast<Motorbike>();

        if (sortedMotorbikes.ToList().Count == 0)
        {
            return null!;
        }
        
        var computer = SortByMotorbikeModel(sortedMotorbikes, model);

        return computer;
    }

    private IQueryable<Motorbike> SortByMotorbikeModel(IQueryable<Motorbike> query, SortMotorbikeDTO model)
    {
        if (!string.IsNullOrEmpty(model.TypeOf))
        {
            query = query.Where(item => item.TypeOf == model.TypeOf);
        }

        if (model.Volume != 0)
        {
            query = query.Where(item => item.Volume == model.Volume);
        }
        
        if (model.NumberOfCylinders != 0)
        {
            query = query.Where(item => item.NumberOfCylinders == model.NumberOfCylinders);
        }
        
        if (model.Power != 0)
        {
            query = query.Where(item => item.Power == model.Power);
        }
        
        query = query.Where(item => item.Cooling == (int) model.Cooling);
        
        if (model.FuelConsumption != 0)
        {
            query = query.Where(item => item.FuelConsumption == model.FuelConsumption);
        }
        
        query = query.Where(item => item.ElectricStarter == (int) model.ElectricStarter);
        
        return query;
    }

    public Motorbike Get(int id)
    {
        return _context.Motorbikes.Where(x => x.Id == id).FirstOrDefault();
    }

    public void Create(CreateMotorbikeDTO model)
    {
        var motorbike = _mapper.Map<CreateMotorbikeDTO, Motorbike>(model);

        _context.Motorbikes.Add(motorbike);
        _context.SaveChanges();
    }

    public void Edit(int id, EditMotorbikeDTO model)
    {
        var motorbike = Get(id);

        if (motorbike.Id == 0)
        {
            return;
        }
        
        var editMotorbike = _mapper.Map<EditMotorbikeDTO, Motorbike>(model);

        _context.Motorbikes.Update(editMotorbike);
        _context.SaveChanges();
    }

    public void Delete(DeleteBasicDTO model)
    {
        _context.Motorbikes.Remove(Get(model.Id));
        _context.SaveChanges();
    }
}