using Microsoft.AspNetCore.Mvc;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.TelevisionDTO;
using OnlinerApp.Model.Models;

namespace OnlinerApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TelevisionController : ControllerBase
{
    private readonly ITelevisionService _televisionService;
    private readonly ILogger<TelevisionController> _logger;

    public TelevisionController(ITelevisionService televisionService, ILogger<TelevisionController> logger)
    {
        _televisionService = televisionService;
        _logger = logger;
    }
    
    [HttpGet("/get/television")]
    public List<Television> Get()
    {
        return _televisionService.Get().ToList();
    }

    [HttpPost("/get/television/sorted")]
    public List<Television> GetSorted(SortTelevisionDTO model)
    {
        return _televisionService.Get(model).ToList();
    }

    [HttpGet("/get/television/{id}")]
    public Television Get(int id)
    {
        return _televisionService.Get(id);
    }
    
    [HttpPost("/create/television")]
    public IActionResult Create(CreateTelevisionDTO model)
    {
        _televisionService.Create(model);
        
        _logger.LogInformation($"Create new television");
            
        return Ok();
    }
    
    [HttpPut("/put/television")]
    public IActionResult Edit(int id, EditTelevisionDTO model)
    {
        _televisionService.Edit(id, model);
        
        _logger.LogInformation($"Edit television {id}");

        return Ok();
    }

    [HttpDelete("/delete/television")]
    public IActionResult Delete(DeleteBasicDTO model)
    {
        _televisionService.Delete(model);
        
        _logger.LogInformation($"Delete television {model.Id}");

        return Ok();
    }
}