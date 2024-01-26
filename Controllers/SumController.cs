using allforone.Services.L1_Sum;
using Microsoft.AspNetCore.Mvc;

namespace allforone.Controllers;

[ApiController]
[Route("[controller]")]
public class SumController : ControllerBase
{
    private readonly ISumService _sumService;
    public SumController(ISumService sumService)
    {
        _sumService = sumService;
    }

    [HttpGet]
    [Route("GetSum/{numOne}/{numTwo}")]
    public string GetSum(string numOne, string numTwo)
    {
        return _sumService.GetSum(numOne, numTwo);
    }
}
