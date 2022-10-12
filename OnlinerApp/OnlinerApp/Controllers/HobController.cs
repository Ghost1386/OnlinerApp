using Microsoft.AspNetCore.Mvc;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.HobDTO;
using OnlinerApp.Model.Models;

namespace OnlinerApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HobController : ControllerBase
{
    private readonly IHobService _hobService;
    private readonly ILogger<HobController> _logger;
    
    public HobController(IHobService hobService, ILogger<HobController> logger)
    {
        _hobService = hobService;
        _logger = logger;
    }
    
    [HttpGet("/get/hob")]
    public List<Hob> Get()
    {
        return _hobService.Get().ToList();
    }

    [HttpPost("/get/hob/sorted")]
    public List<Hob> GetSorted(SortHobDTO model)
    {
        return _hobService.Get(model).ToList();
    }

    [HttpGet("/get/hob/{id}")]
    public Hob Get(int id)
    {
        return _hobService.Get(id);
    }
    
    [HttpPost("/create/hob")]
    public IActionResult Create(CreateHobDTO model)
    {
        _hobService.Create(model);
        
        _logger.LogInformation($"Create new hob");
            
        return Ok();
    }
    
    [HttpPut("/put/hob")]
    public IActionResult Edit(int id, EditHobDTO model)
    {
        _hobService.Edit(id, model);
        
        _logger.LogInformation($"Edit hob {id}");

        return Ok();
    }

    [HttpDelete("/delete/hob")]
    public IActionResult Delete(DeleteBasicDTO model)
    {
        _hobService.Delete(model);
        
        _logger.LogInformation($"Delete hob {model.Id}");

        return Ok();
    }
}