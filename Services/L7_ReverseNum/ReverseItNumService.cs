namespace allforone.Services.L7_ReverseNum;
public class ReverseNumService : IReverseNumService
{
    public string ReverseItNumOnly(string userNum)
    {
        bool numConvert = Int32.TryParse(userNum, out int userNumInt);
        int reverseNum = 0;
        int changeNum = userNumInt;

        if (numConvert)
        {
            while (changeNum > 0)
            {
                reverseNum = (reverseNum * 10) + (changeNum % 10);
                changeNum /= 10;
            }
            return $"Original number: {userNumInt}\nReversed nnumber: {reverseNum}";

        }
        else
        {
            return "Error: Please enter an integer number.";
        }
    }
}