using Microsoft.AspNetCore.Mvc;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.DeleteDTO;
using OnlinerApp.Common.DTO_s.MotorbikeDTO;
using OnlinerApp.Model.Models;

namespace OnlinerApp.Controllers;

public class MotorbikeController : ControllerBase
{
    private readonly IMotorbikeService _motorbikeService;
    private readonly ILogger<MotorbikeController> _logger;
    
    public MotorbikeController(IMotorbikeService motorbikeService, ILogger<MotorbikeController> logger)
    {
        _motorbikeService = motorbikeService;
        _logger = logger;
    }

    [HttpGet("/get/motorbike")]
    public List<Motorbike> Get()
    {
        return _motorbikeService.Get().ToList();
    }

    [HttpPost("/get/motorbike/sorted")]
    public List<Motorbike> GetSorted(SortMotorbikeDTO model)
    {
        return _motorbikeService.Get(model).ToList();
    }

    [HttpGet("/get/motorbike/{id}")]
    public Motorbike Get(int id)
    {
        return _motorbikeService.Get(id);
    }
    
    [HttpPost("/create/motorbike")]
    public IActionResult Create(CreateMotorbikeDTO model)
    {
        _motorbikeService.Create(model);
        
        _logger.LogInformation($"Create new motorbike");
            
        return Ok();
    }
    
    [HttpPut("/put/motorbike")]
    public IActionResult Edit(int id, EditMotorbikeDTO model)
    {
        _motorbikeService.Edit(id, model);
        
        _logger.LogInformation($"Edit motorbike {id}");

        return Ok();
    }

    [HttpDelete("/delete/motorbike")]
    public IActionResult Delete(DeleteBasicDTO model)
    {
        _motorbikeService.Delete(model);
        
        _logger.LogInformation($"Delete motorbike {model.Id}");

        return Ok();
    }
}