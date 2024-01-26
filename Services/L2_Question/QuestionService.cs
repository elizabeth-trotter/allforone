namespace allforone.Services.L2_Question;
public class QuestionService : IQuestionService
{
    public string GetAnswers(string name, string time)
    {
        return $"{name} woke up at {time} today!";
    }
}