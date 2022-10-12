using AutoMapper;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.MicrowaveDTO;
using OnlinerApp.Model;
using OnlinerApp.Model.Models;

namespace OnlinerApp.BusinessLogic.Services;

public class MicrowaveService : IMicrowaveService
{
    private readonly ApplicationContext _context;
    private readonly IMapper _mapper;
    private readonly ISortService _sortService;

    public MicrowaveService(ApplicationContext context, IMapper mapper, ISortService sortService)
    {
        _context = context;
        _mapper = mapper;
        _sortService = sortService;
    }

    public IEnumerable<Microwave> Get()
    {
        return _context.Microwaves;
    }

    public IQueryable<Microwave> Get(SortMicrowaveDTO model)
    {
        var basicModel = new List<BasicModel>();
        
        basicModel.AddRange(_context.Microwaves);

        var sortedModels = _sortService.Sort(basicModel.AsQueryable(), model);

        var sortedMicrowaves = sortedModels.Cast<Microwave>();

        if (sortedMicrowaves.ToList().Count == 0)
        {
            return null!;
        }
        
        var microwave = SortByMicrowaveModel(sortedMicrowaves, model);

        return microwave;
    }

    private IQueryable<Microwave> SortByMicrowaveModel(IQueryable<Microwave> query, SortMicrowaveDTO model)
    {
        query = query.Where(item => item.Execution == (int) model.Execution);
        
        query = query.Where(item => item.TypeOf == (int) model.TypeMicrowave);

        if (model.Volume != 0)
        {
            query = query.Where(item => item.Volume == model.Volume);
        }
        
        query = query.Where(item => item.Control == (int) model.Control);
        
        query = query.Where(item => item.DoorDesign == (int) model.DoorDesign);
        
        if (model.Power != 0)
        {
            query = query.Where(item => item.Power == model.Power);
        }
        
        query = query.Where(item => item.RotaryTable == (int) model.RotaryTable);
        
        return query;
    }

    public Microwave Get(int id)
    {
        return _context.Microwaves.Where(x => x.Id == id).FirstOrDefault();
    }

    public void Create(CreateMicrowaveDTO model)
    {
        var microwave = _mapper.Map<CreateMicrowaveDTO, Microwave>(model);

        _context.Microwaves.Add(microwave);
        _context.SaveChanges();
    }

    public void Edit(int id, EditMicrowaveDTO model)
    {
        var microwave = Get(id);

        if (microwave.Id == 0)
        {
            return;
        }
        
        var editMicrowave = _mapper.Map<EditMicrowaveDTO, Microwave>(model);

        _context.Microwaves.Update(editMicrowave);
        _context.SaveChanges();
    }

    public void Delete(DeleteBasicDTO model)
    {
        _context.Microwaves.Remove(Get(model.Id));
        _context.SaveChanges();
    }
}