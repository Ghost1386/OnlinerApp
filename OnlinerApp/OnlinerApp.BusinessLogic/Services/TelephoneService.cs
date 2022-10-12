using AutoMapper;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.TelephoneDTO;
using OnlinerApp.Model;
using OnlinerApp.Model.Models;

namespace OnlinerApp.BusinessLogic.Services;

public class TelephoneService : ITelephoneService
{
    private readonly ApplicationContext _context;
    private readonly IMapper _mapper;
    private readonly ISortService _sortService;

    public TelephoneService(ApplicationContext context, IMapper mapper, ISortService sortService)
    {
        _context = context;
        _mapper = mapper;
        _sortService = sortService;
    }

    public IEnumerable<Telephone> Get()
    {
        return _context.Telephones;
    }

    public IQueryable<Telephone> Get(SortTelephoneDTO model)
    {
        var basicModel = new List<BasicModel>();
        
        basicModel.AddRange(_context.Telephones);

        var sortedModels = _sortService.Sort(basicModel.AsQueryable(), model);

        var sortedTelephones = sortedModels.Cast<Telephone>();

        if (sortedTelephones.ToList().Count == 0)
        {
            return null!;
        }
        
        var telephone = SortByTelephoneModel(sortedTelephones, model);

        return telephone;
    }

    private IQueryable<Telephone> SortByTelephoneModel(IQueryable<Telephone> query, SortTelephoneDTO model)
    {
        if (model.Ram != 0)
        {
            query = query.Where(item => item.Ram == model.Ram);
        }
        
        if (model.BuiltInMemory != 0)
        {
            query = query.Where(item => item.BuiltInMemory == model.BuiltInMemory);
        }
        
        if (model.ScreenSize != 0)
        {
            query = query.Where(item => item.ScreenSize == model.ScreenSize);
        }
        
        query = query.Where(item => item.OperatingSystem == (int) model.OperatingSystem);
        
        if (model.BatteryCapacity != 0)
        {
            query = query.Where(item => item.BatteryCapacity == model.BatteryCapacity);
        }
        
        query = query.Where(item => item.TypeOf == (int) model.TypeOf);
        
        if (!string.IsNullOrEmpty(model.CaseColor))
        {
            query = query.Where(item => item.CaseColor == model.CaseColor);
        }
        
        return query;
    }

    public Telephone Get(int id)
    {
        return _context.Telephones.Where(x => x.Id == id).FirstOrDefault();
    }

    public void Create(CreateTelephoneDTO model)
    {
        var telephone = _mapper.Map<CreateTelephoneDTO, Telephone>(model);

        _context.Telephones.Add(telephone);
        _context.SaveChanges();
    }

    public void Edit(int id, EditTelephoneDTO model)
    {
        var telephone = Get(id);

        if (telephone.Id == 0)
        {
            return;
        }
        
        var editTelephone = _mapper.Map<EditTelephoneDTO, Telephone>(model);

        _context.Telephones.Update(editTelephone);
        _context.SaveChanges();
    }

    public void Delete(DeleteBasicDTO model)
    {
        _context.Telephones.Remove(Get(model.Id));
        _context.SaveChanges();
    }
}