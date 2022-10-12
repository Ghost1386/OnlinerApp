using Microsoft.AspNetCore.Mvc;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.WasherDTO;
using OnlinerApp.Model.Models;

namespace OnlinerApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WasherController : ControllerBase
{
    private readonly IWasherService _washerService;
    private readonly ILogger<WasherController> _logger;

    public WasherController(IWasherService washerService, ILogger<WasherController> logger)
    {
        _washerService = washerService;
        _logger = logger;
    }
    
    [HttpGet("/get/washer")]
    public List<Washer> Get()
    {
        return _washerService.Get().ToList();
    }

    [HttpPost("/get/washer/sorted")]
    public List<Washer> GetSorted(SortWasherDTO model)
    {
        return _washerService.Get(model).ToList();
    }

    [HttpGet("/get/washer/{id}")]
    public Washer Get(int id)
    {
        return _washerService.Get(id);
    }
    
    [HttpPost("/create/washer")]
    public IActionResult Create(CreateWasherDTO model)
    {
        _washerService.Create(model);
        
        _logger.LogInformation($"Create new washer");
            
        return Ok();
    }
    
    [HttpPut("/put/washer")]
    public IActionResult Edit(int id, EditWasherDTO model)
    {
        _washerService.Edit(id, model);
        
        _logger.LogInformation($"Edit washer {id}");

        return Ok();
    }

    [HttpDelete("/delete/washer")]
    public IActionResult Delete(DeleteBasicDTO model)
    {
        _washerService.Delete(model);
        
        _logger.LogInformation($"Delete washer {model.Id}");

        return Ok();
    }
}