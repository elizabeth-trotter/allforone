namespace allforone.Services.L3_Compare;
public class CompareService : ICompareService
{
    public string CompareNums(string numberOne, string numberTwo)
    {   
        int numberOneInt;
        int numberTwoInt;
        bool isOneTrue = int.TryParse(numberOne, out numberOneInt);
        bool isTwoTrue = int.TryParse(numberTwo, out numberTwoInt);

        if(isOneTrue && isTwoTrue){
            if(numberOneInt > numberTwoInt){
            return $"{numberOneInt} > {numberTwoInt}!";
        } else if(numberOneInt < numberTwoInt){
            return $"{numberOneInt} < {numberTwoInt}!";
        } else{
            return $"{numberOneInt} = {numberTwoInt}!";
        }
        }else{
            return "Invalid input.";
        }
        
    }
}
