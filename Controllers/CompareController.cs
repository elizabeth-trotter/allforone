using allforone.Services.L3_Compare;
using Microsoft.AspNetCore.Mvc;

namespace allforone.Controllers;

[ApiController]
[Route("[controller]")]
public class CompareController : ControllerBase
{
    private readonly ICompareService _compareService;
    public CompareController(ICompareService compareService)
    {
        _compareService = compareService;
    }

    [HttpGet]
    [Route("CompareNums/{numberOne}/{numberTwo}")]
    public string CompareNums(string numberOne, string numberTwo)
    {
        return _compareService.CompareNums(numberOne, numberTwo);
    }
}
