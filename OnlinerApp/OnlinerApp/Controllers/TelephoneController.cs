using Microsoft.AspNetCore.Mvc;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.TelephoneDTO;
using OnlinerApp.Model.Models;

namespace OnlinerApp.Controllers;

public class TelephoneController : ControllerBase
{
    private readonly ITelephoneService _telephoneService;
    private readonly ILogger<TelephoneController> _logger;

    public TelephoneController(ITelephoneService telephoneService, ILogger<TelephoneController> logger)
    {
        _telephoneService = telephoneService;
        _logger = logger;
    }
    
    [HttpGet("/get/telephone")]
    public List<Telephone> Get()
    {
        return _telephoneService.Get().ToList();
    }

    [HttpPost("/get/telephone/sorted")]
    public List<Telephone> GetSorted(SortTelephoneDTO model)
    {
        return _telephoneService.Get(model).ToList();
    }

    [HttpGet("/get/telephone/{id}")]
    public Telephone Get(int id)
    {
        return _telephoneService.Get(id);
    }
    
    [HttpPost("/create/telephone")]
    public IActionResult Create(CreateTelephoneDTO model)
    {
        _telephoneService.Create(model);
        
        _logger.LogInformation($"Create new telephone");
            
        return Ok();
    }
    
    [HttpPut("/put/telephone")]
    public IActionResult Edit(int id, EditTelephoneDTO model)
    {
        _telephoneService.Edit(id, model);
        
        _logger.LogInformation($"Edit telephone {id}");

        return Ok();
    }

    [HttpDelete("/delete/telephone")]
    public IActionResult Delete(DeleteBasicDTO model)
    {
        _telephoneService.Delete(model);
        
        _logger.LogInformation($"Delete telephone {model.Id}");

        return Ok();
    }
}