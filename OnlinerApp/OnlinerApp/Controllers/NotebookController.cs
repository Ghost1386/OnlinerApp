using Microsoft.AspNetCore.Mvc;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.NotebookDTO;
using OnlinerApp.Common.DTO_s.СomputerDTO;
using OnlinerApp.Model.Models;

namespace OnlinerApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NotebookController : ControllerBase
{
    private readonly INotebookService _notebookService;
    private readonly ILogger<NotebookController> _logger;
    
    public NotebookController(INotebookService notebookService, ILogger<NotebookController> logger)
    {
        _notebookService = notebookService;
        _logger = logger;
    }
    
    [HttpGet("/get/notebook")]
    public List<Notebook> Get()
    {
        return _notebookService.Get().ToList();
    }

    [HttpPost("/get/notebook/sorted")]
    public List<Notebook> GetSorted(SortNotebookDTO model)
    {
        return _notebookService.Get(model).ToList();
    }

    [HttpGet("/get/notebook/{id}")]
    public Notebook Get(int id)
    {
        return _notebookService.Get(id);
    }
    
    [HttpPost("/create/notebook")]
    public IActionResult Create(CreateNotebookDTO model)
    {
        _notebookService.Create(model);
        
        _logger.LogInformation($"Create new notebook");
            
        return Ok();
    }
    
    [HttpPut("/put/notebook")]
    public IActionResult Edit(int id, EditNotebookDTO model)
    {
        _notebookService.Edit(id, model);
        
        _logger.LogInformation($"Edit notebook {id}");

        return Ok();
    }

    [HttpDelete("/delete/notebook")]
    public IActionResult Delete(DeleteBasicDTO model)
    {
        _notebookService.Delete(model);
        
        _logger.LogInformation($"Delete notebook {model.Id}");

        return Ok();
    }
}