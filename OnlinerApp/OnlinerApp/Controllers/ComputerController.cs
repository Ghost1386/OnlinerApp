using Microsoft.AspNetCore.Mvc;
using OnlinerApp.BusinessLogic.Interfaces;
using OnlinerApp.Common.DTO_s.СomputerDTO;
using OnlinerApp.Model.Models;

namespace OnlinerApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ComputerController : ControllerBase
{
    private readonly IComputerService _computerService;

    public ComputerController(IComputerService computerService)
    {
        _computerService = computerService;
    }

    [HttpGet]
    public List<Сomputer> Get()
    {
        return _computerService.Get().ToList();
    }

    [HttpPost]
    public List<Сomputer> GetSorted(SortСomputerDTO model)
    {
        return _computerService.Get(model).ToList();
    }
}