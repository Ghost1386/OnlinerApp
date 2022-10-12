using Microsoft.AspNetCore.Mvc;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.FridgeDTO;
using OnlinerApp.Model.Models;

namespace OnlinerApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FridgeController : ControllerBase
{
    private readonly IFridgeService _fridgeService;
    private readonly ILogger<FridgeController> _logger;
    
    public FridgeController(IFridgeService fridgeService, ILogger<FridgeController> logger)
    {
        _fridgeService = fridgeService;
        _logger = logger;
    }
    
    [HttpGet("/get/fridge")]
    public List<Fridge> Get()
    {
        return _fridgeService.Get().ToList();
    }

    [HttpPost("/get/fridge/sorted")]
    public List<Fridge> GetSorted(SortFridgeDTO model)
    {
        try
        {
            return _fridgeService.Get(model).ToList();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return new List<Fridge>();
        }
    }

    [HttpGet("/get/fridge/{id}")]
    public Fridge Get(int id)
    {
        try
        {
            return _fridgeService.Get(id);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return new Fridge();
        }
    }
    
    [HttpPost("/create/fridge")]
    public IActionResult Create(CreateFridgeDTO model)
    {
        try
        {
            _fridgeService.Create(model);
        
            _logger.LogInformation($"Create new fridge");
            
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest();
        }
    }
    
    [HttpPut("/put/fridge")]
    public IActionResult Edit(int id, EditFridgeDTO model)
    {
        try
        {
            _fridgeService.Edit(id, model);
        
            _logger.LogInformation($"Edit fridge {id}");

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest();
        }
    }

    [HttpDelete("/delete/fridge")]
    public IActionResult Delete(DeleteBasicDTO model)
    {
        try
        {
            _fridgeService.Delete(model);
        
            _logger.LogInformation($"Delete fridge {model.Id}");

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest();
        }
    }
}