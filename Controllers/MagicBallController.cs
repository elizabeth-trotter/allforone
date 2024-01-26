using allforone.Services.L8_MagicBall;
using Microsoft.AspNetCore.Mvc;

namespace allforone.Controllers;

[ApiController]
[Route("[controller]")]
public class MagicBallController : ControllerBase
{
    private readonly IMagicBallService _magicBallService;

    public MagicBallController(IMagicBallService magicBallService)
    {
        _magicBallService = magicBallService;
    }

    [HttpGet]
    [Route("Generate8BallResponseToQuestion/")]
    public string Generate()
    {
        return _magicBallService.Generate();
    }
}
