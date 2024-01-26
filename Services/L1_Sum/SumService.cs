namespace allforone.Services.L1_Sum;
public class SumService : ISumService
{
    public string GetSum(string numOne, string numTwo)
    {
        int numOneInt;
        bool isOneTrue = int.TryParse(numOne, out numOneInt);

        int numTwoInt;
        bool isTwoTrue = int.TryParse(numTwo, out numTwoInt);

        if(isOneTrue && isTwoTrue){
            return $"{numOneInt} + {numTwoInt} = {numOneInt + numTwoInt}!";
        }else{
            return "Invalid input.";
        }
    }
}
