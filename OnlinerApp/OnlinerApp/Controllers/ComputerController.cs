using Microsoft.AspNetCore.Mvc;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.СomputerDTO;
using OnlinerApp.Model.Models;

namespace OnlinerApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ComputerController : ControllerBase
{
    private readonly IComputerService _computerService;
    private readonly ILogger<ComputerController> _logger;

    public ComputerController(IComputerService computerService, ILogger<ComputerController> logger)
    {
        _computerService = computerService;
        _logger = logger;
    }

    [HttpGet("/get/computer")]
    public List<Сomputer> Get()
    {
        return _computerService.Get().ToList();
    }

    [HttpPost("/get/computer/sorted")]
    public List<Сomputer> GetSorted(SortСomputerDTO model)
    {
        return _computerService.Get(model).ToList();
    }

    [HttpGet("/get/computer/{id}")]
    public Сomputer Get(int id)
    {
        return _computerService.Get(id);
    }
    
    [HttpPost("/create/computer")]
    public IActionResult Create(CreateСomputerDTO model)
    {
        _computerService.Create(model);
        
        _logger.LogInformation($"Create new computer");
            
        return Ok();
    }
    
    [HttpPut("/put/computer")]
    public IActionResult Edit(int id, EditСomputerDTO model)
    {
        _computerService.Edit(id, model);
        
        _logger.LogInformation($"Edit computer {id}");

        return Ok();
    }

    [HttpDelete("/delete/computer")]
    public IActionResult Delete(DeleteBasicDTO model)
    {
        _computerService.Delete(model);
        
        _logger.LogInformation($"Delete computer {model.Id}");

        return Ok();
    }
}