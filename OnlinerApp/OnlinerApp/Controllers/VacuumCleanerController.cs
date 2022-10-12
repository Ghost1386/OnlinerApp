using Microsoft.AspNetCore.Mvc;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.VacuumCleanerDTO;
using OnlinerApp.Model.Models;

namespace OnlinerApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VacuumCleanerController : ControllerBase
{
    private readonly IVacuumCleanerService _vacuumCleanerService;
    private readonly ILogger<VacuumCleanerController> _logger;

    public VacuumCleanerController(IVacuumCleanerService vacuumCleanerService, ILogger<VacuumCleanerController> logger)
    {
        _vacuumCleanerService = vacuumCleanerService;
        _logger = logger;
    }
    
    [HttpGet("/get/vacuumCleaner")]
    public List<VacuumCleaner> Get()
    {
        return _vacuumCleanerService.Get().ToList();
    }

    [HttpPost("/get/vacuumCleaner/sorted")]
    public List<VacuumCleaner> GetSorted(SortVacuumCleanerDTO model)
    {
        return _vacuumCleanerService.Get(model).ToList();
    }

    [HttpGet("/get/vacuumCleaner/{id}")]
    public VacuumCleaner Get(int id)
    {
        return _vacuumCleanerService.Get(id);
    }
    
    [HttpPost("/create/vacuumCleaner")]
    public IActionResult Create(CreateVacuumCleanerDTO model)
    {
        _vacuumCleanerService.Create(model);
        
        _logger.LogInformation($"Create new vacuum cleaner");
            
        return Ok();
    }
    
    [HttpPut("/put/vacuumCleaner")]
    public IActionResult Edit(int id, EditVacuumCleanerDTO model)
    {
        _vacuumCleanerService.Edit(id, model);
        
        _logger.LogInformation($"Edit vacuum cleaner {id}");

        return Ok();
    }

    [HttpDelete("/delete/vacuumCleaner")]
    public IActionResult Delete(DeleteBasicDTO model)
    {
        _vacuumCleanerService.Delete(model);
        
        _logger.LogInformation($"Delete vacuum cleaner {model.Id}");

        return Ok();
    }
}