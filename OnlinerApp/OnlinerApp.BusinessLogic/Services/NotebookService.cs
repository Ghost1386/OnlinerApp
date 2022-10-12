using AutoMapper;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.NotebookDTO;
using OnlinerApp.Model;
using OnlinerApp.Model.Models;

namespace OnlinerApp.BusinessLogic.Services;

public class NotebookService : INotebookService
{
    private readonly ApplicationContext _context;
    private readonly IMapper _mapper;
    private readonly ISortService _sortService;

    public NotebookService(ApplicationContext context, IMapper mapper, ISortService sortService)
    {
        _context = context;
        _mapper = mapper;
        _sortService = sortService;
    }

    public IEnumerable<Notebook> Get()
    {
        return _context.Notebooks;
    }

    public IQueryable<Notebook> Get(SortNotebookDTO model)
    {
        var basicModel = new List<BasicModel>();
        
        basicModel.AddRange(_context.Notebooks);

        var sortedModels = _sortService.Sort(basicModel.AsQueryable(), model);

        var sortedNotebooks = sortedModels.Cast<Notebook>();

        if (sortedNotebooks.ToList().Count == 0)
        {
            return null!;
        }
        
        var notebook = SortByNotebookModel(sortedNotebooks, model);

        return notebook;
    }

    private IQueryable<Notebook> SortByNotebookModel(IQueryable<Notebook> query, SortNotebookDTO model)
    {
        if (model.Diagonal != 0)
        {
            query = query.Where(item => item.Diagonal == model.Diagonal);
        }
        
        if (!string.IsNullOrEmpty(model.Cpu))
        {
            query = query.Where(item => item.Cpu == model.Cpu);
        }
        
        if (model.Ram != 0)
        {
            query = query.Where(item => item.Ram == model.Ram);
        }
        
        if (!string.IsNullOrEmpty(model.VideoCard))
        {
            query = query.Where(item => item.VideoCard == model.VideoCard);
        }
        
        query = query.Where(item => item.DriveType == (int) model.DriveType);
        
        if (model.DriveCapacity != 0)
        {
            query = query.Where(item => item.DriveCapacity == model.DriveCapacity);
        }
        
        query = query.Where(item => item.ScreenMatrix == (int) model.ScreenMatrix);
        
        if (model.MatrixFrequency != 0)
        {
            query = query.Where(item => item.MatrixFrequency == model.MatrixFrequency);
        }
        
        query = query.Where(item => item.OperatingSystem == (int) model.OperatingSystem);
        
        return query;
    }

    public Notebook Get(int id)
    {
        return _context.Notebooks.Where(x => x.Id == id).FirstOrDefault();
    }

    public void Create(CreateNotebookDTO model)
    {
        var notebook = _mapper.Map<CreateNotebookDTO, Notebook>(model);

        _context.Notebooks.Add(notebook);
        _context.SaveChanges();
    }

    public void Edit(int id, EditNotebookDTO model)
    {
        var notebook = Get(id);

        if (notebook.Id == 0)
        {
            return;
        }
        
        var editNotebook = _mapper.Map<EditNotebookDTO, Notebook>(model);

        _context.Notebooks.Update(editNotebook);
        _context.SaveChanges();
    }

    public void Delete(DeleteBasicDTO model)
    {
        _context.Notebooks.Remove(Get(model.Id));
        _context.SaveChanges();
    }
}