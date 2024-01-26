using allforone.Services.L4_Madlib;
using Microsoft.AspNetCore.Mvc;

namespace allforone.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
    private readonly IMadLibService _madLibService;

    public MadLibController(IMadLibService madLibService)
    {
        _madLibService = madLibService;
    }

    [HttpGet]
    [Route("MadLib/{noun1}/{holiday1}/{pronoun1}/{animal1}/{exclamation1}/{color1}/{noun2}/{verb1_ing}/{bluntObject1}/{hours1}")]
    public string MadLib(string noun1, string holiday1, string pronoun1, string animal1, string exclamation1, string color1, string noun2, string verb1_ing, string bluntObject1, string hours1)
    {
        return _madLibService.MadLib(noun1, holiday1, pronoun1, animal1, exclamation1, color1, noun2, verb1_ing, bluntObject1, hours1);
    }
}