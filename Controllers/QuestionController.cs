using allforone.Services.L2_Question;
using Microsoft.AspNetCore.Mvc;

namespace allforone.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionController : ControllerBase
{   
    private readonly IQuestionService _questionService;
    public QuestionController(IQuestionService questionService)
    {
        _questionService = questionService;
    }

    [HttpGet]
    [Route("GetAnswers/{name}/{time}")]
    public string GetAnswers(string name, string time)
    {
        return _questionService.GetAnswers(name, time);
    }
}
