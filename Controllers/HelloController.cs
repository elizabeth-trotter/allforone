using allforone.Services.L0_Hello;
using Microsoft.AspNetCore.Mvc;

namespace allforone.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    private readonly IHelloService _helloService;

    public HelloController(IHelloService helloService)
    {
        _helloService = helloService;
    }

    [HttpGet]
    [Route("Hello/{userName}")]
    public string Hello(string userName)
    {
        return _helloService.Hello(userName);
    }
}
