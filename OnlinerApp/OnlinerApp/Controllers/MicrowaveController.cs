using Microsoft.AspNetCore.Mvc;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.MicrowaveDTO;
using OnlinerApp.Model.Models;

namespace OnlinerApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MicrowaveController : ControllerBase
{
    private readonly IMicrowaveService _microwaveService;
    private readonly ILogger<MicrowaveController> _logger;

    public MicrowaveController(IMicrowaveService microwaveService, ILogger<MicrowaveController> logger)
    {
        _microwaveService = microwaveService;
        _logger = logger;
    }
    
    [HttpGet("/get/microwave")]
    public List<Microwave> Get()
    {
        return _microwaveService.Get().ToList();
    }

    [HttpPost("/get/microwave/sorted")]
    public List<Microwave> GetSorted(SortMicrowaveDTO model)
    {
        return _microwaveService.Get(model).ToList();
    }

    [HttpGet("/get/microwave/{id}")]
    public Microwave Get(int id)
    {
        return _microwaveService.Get(id);
    }
    
    [HttpPost("/create/microwave")]
    public IActionResult Create(CreateMicrowaveDTO model)
    {
        _microwaveService.Create(model);
        
        _logger.LogInformation($"Create new computer");
            
        return Ok();
    }
    
    [HttpPut("/put/microwave")]
    public IActionResult Edit(int id, EditMicrowaveDTO model)
    {
        _microwaveService.Edit(id, model);
        
        _logger.LogInformation($"Edit computer {id}");

        return Ok();
    }

    [HttpDelete("/delete/microwave")]
    public IActionResult Delete(DeleteBasicDTO model)
    {
        _microwaveService.Delete(model);
        
        _logger.LogInformation($"Delete computer {model.Id}");

        return Ok();
    }
}