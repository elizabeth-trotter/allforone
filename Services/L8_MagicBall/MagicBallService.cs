namespace allforone.Services.L8_MagicBall;
public class MagicBallService : IMagicBallService
{
    public string Generate()
    {
        Random eightBall = new Random();
        int num = eightBall.Next(8);

        switch (num)
        {
            case 0:
                return "Outlook is positive.";
            case 1:
                return "Outlook seems not that great..";
            case 2:
                return "Yes, absolutely.";
            case 3:
                return "Neither yes or no. Maybe.";
            case 4:
                return "Outlook is neutral.";
            case 5:
                return "Possibly.";
            case 6:
                return "No.";
            default:
                return "YES!";
        }
    }
}
