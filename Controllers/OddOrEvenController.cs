using allforone.Services.L5_OddEven;
using Microsoft.AspNetCore.Mvc;

namespace allforone.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    private readonly IOddOrEvenService _oddOrEvenService;

    public OddOrEvenController(IOddOrEvenService oddOrEvenService)
    {
        _oddOrEvenService = oddOrEvenService;
    }

    [HttpGet]
    [Route("OddOrEven/{numOne}")]
    public string OddOrEven(string numOne)
    {
        return _oddOrEvenService.OddOrEven(numOne);
    }
}