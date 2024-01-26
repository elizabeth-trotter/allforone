using allforone.Services.L6_ReverseStr;
using Microsoft.AspNetCore.Mvc;

namespace allforone.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItAlphaController : ControllerBase
{
    private readonly IReverseItAlphaService _reverseItAlphaService;

    public ReverseItAlphaController(IReverseItAlphaService reverseItAlphaService)
    {
        _reverseItAlphaService = reverseItAlphaService;
    }

    [HttpGet]
    [Route("ReverseIt/Entersequenceoflettersandornumbers{userInput}")]
    public string ReverseIt(string userInput)
    {
        return _reverseItAlphaService.ReverseIt(userInput);
    }
}