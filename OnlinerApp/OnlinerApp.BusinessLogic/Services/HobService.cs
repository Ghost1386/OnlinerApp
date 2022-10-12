using AutoMapper;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.HobDTO;
using OnlinerApp.Model;
using OnlinerApp.Model.Models;

namespace OnlinerApp.BusinessLogic.Services;

public class HobService : IHobService
{
    private readonly ApplicationContext _context;
    private readonly IMapper _mapper;
    private readonly ISortService _sortService;

    public HobService(ApplicationContext context, IMapper mapper, ISortService sortService)
    {
        _context = context;
        _mapper = mapper;
        _sortService = sortService;
    }

    public IEnumerable<Hob> Get()
    {
        return _context.Hobs;
    }

    public IQueryable<Hob> Get(SortHobDTO model)
    {
        var basicModel = new List<BasicModel>();
        
        basicModel.AddRange(_context.Microwaves);

        var sortedModels = _sortService.Sort(basicModel.AsQueryable(), model);

        var sortedHobs = sortedModels.Cast<Hob>();

        if (sortedHobs.ToList().Count == 0)
        {
            return null!;
        }
        
        var hob = SortByHobModel(sortedHobs, model);

        return hob;
    }

    private IQueryable<Hob> SortByHobModel(IQueryable<Hob> query, SortHobDTO model)
    {
        if (!string.IsNullOrEmpty(model.TypeOf))
        {
            query = query.Where(item => item.TypeOf == model.TypeOf);
        }

        if (model.NumberOfBurners != 0)
        {
            query = query.Where(item => item.NumberOfBurners == model.NumberOfBurners);
        }
        
        if (!string.IsNullOrEmpty(model.Color))
        {
            query = query.Where(item => item.Color == model.Color);
        }
        
        query = query.Where(item => item.Lattices == (int) model.Lattices);
        
        query = query.Where(item => item.WorkingSurface == (int) model.WorkingSurface);
        
        query = query.Where(item => item.ElectricIgnition == (int) model.ElectricIgnition);
        
        query = query.Where(item => item.AutomaticBoiling == (int) model.AutomaticBoiling);
        
        return query;
    }

    public Hob Get(int id)
    {
        return _context.Hobs.Where(x => x.Id == id).FirstOrDefault();
    }

    public void Create(CreateHobDTO model)
    {
        var hob = _mapper.Map<CreateHobDTO, Hob>(model);

        _context.Hobs.Add(hob);
        _context.SaveChanges();
    }

    public void Edit(int id, EditHobDTO model)
    {
        var hob = Get(id);

        if (hob.Id == 0)
        {
            return;
        }
        
        var editHob = _mapper.Map<EditHobDTO, Hob>(model);

        _context.Hobs.Update(editHob);
        _context.SaveChanges();
    }

    public void Delete(DeleteBasicDTO model)
    {
        _context.Hobs.Remove(Get(model.Id));
        _context.SaveChanges();
    }
}