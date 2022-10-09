using AutoMapper;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.TelevisionDTO;
using OnlinerApp.Model;
using OnlinerApp.Model.Models;

namespace OnlinerApp.BusinessLogic.Services;

public class TelevisionService : ITelevisionService
{
    private readonly ApplicationContext _context;
    private readonly IMapper _mapper;
    private readonly ISortService _sortService;

    public TelevisionService(ApplicationContext context, IMapper mapper, ISortService sortService)
    {
        _context = context;
        _mapper = mapper;
        _sortService = sortService;
    }

    public IEnumerable<Television> Get()
    {
        return _context.Televisions;
    }

    public IQueryable<Television> Get(SortTelevisionDTO model)
    {
        var basicModel = new List<BasicModel>();
        
        basicModel.AddRange(_context.Televisions);

        var sortedModels = _sortService.Sort(basicModel.AsQueryable(), model);

        var sortedTelevisions = sortedModels.Cast<Television>();

        if (sortedTelevisions.ToList().Count == 0)
        {
            return null!;
        }
        
        var television = SortByTelevisionModel(sortedTelevisions, model);

        if (television.ToList().Count == 0)
        {
            return new List<Television>().AsQueryable();
        }

        return television;
    }

    private IQueryable<Television> SortByTelevisionModel(IQueryable<Television> query, SortTelevisionDTO model)
    {
        if (model.ScreenSize != 0)
        {
            query = query.Where(item => item.ScreenSize == model.ScreenSize);
        }
        
        if (!string.IsNullOrEmpty(model.Permission))
        {
            query = query.Where(item => item.Permission == model.Permission);
        }
        
        query = query.Where(item => item.TypeOf == (int) model.TypeOf);
        
        query = query.Where(item => item.Platform == (int) model.Platform);
        
        query = query.Where(item => item.MatrixType == (int) model.MatrixType);
        
        if (model.Frequency != 0)
        {
            query = query.Where(item => item.Frequency == model.Frequency);
        }
        
        return query;
    }

    public Television Get(int id)
    {
        return _context.Televisions.Where(x => x.Id == id).FirstOrDefault();
    }

    public void Create(CreateTelevisionDTO model)
    {
        var television = _mapper.Map<CreateTelevisionDTO, Television>(model);

        _context.Televisions.Add(television);
        _context.SaveChanges();
    }

    public void Edit(int id, EditTelevisionDTO model)
    {
        var television = Get(id);

        if (television.Id == 0)
        {
            return;
        }
        
        var editTelevision = _mapper.Map<EditTelevisionDTO, Television>(model);

        _context.Televisions.Update(editTelevision);
        _context.SaveChanges();
    }

    public void Delete(DeleteBasicDTO model)
    {
        _context.Televisions.Remove(Get(model.Id));
        _context.SaveChanges();
    }
}