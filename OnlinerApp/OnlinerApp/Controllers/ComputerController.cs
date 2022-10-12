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
        try
        {
            return _computerService.Get(model).ToList();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return new List<Сomputer>();
        }
    }

    [HttpGet("/get/computer/{id}")]
    public Сomputer Get(int id)
    {
        try
        {
            return _computerService.Get(id);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return new Сomputer();
        }
    }
    
    [HttpPost("/create/computer")]
    public IActionResult Create(CreateСomputerDTO model)
    {
        try
        {
            _computerService.Create(model);
        
            _logger.LogInformation($"Create new computer");
            
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest();
        }
    }
    
    [HttpPut("/put/computer")]
    public IActionResult Edit(int id, EditСomputerDTO model)
    {
        try
        {
            _computerService.Edit(id, model);
        
            _logger.LogInformation($"Edit computer {id}");

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest();
        }
    }

    [HttpDelete("/delete/computer")]
    public IActionResult Delete(DeleteBasicDTO model)
    {
        try
        {
            _computerService.Delete(model);
        
            _logger.LogInformation($"Delete computer {model.Id}");

            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            return BadRequest();
        }
    }
}