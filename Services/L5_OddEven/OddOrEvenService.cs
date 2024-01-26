namespace allforone.Services.L5_OddEven;
public class OddOrEvenService : IOddOrEvenService
{
    public string OddOrEven(string numOne)
    {
        bool oneConvert = Int32.TryParse(numOne, out int numOneInt);

        if (oneConvert)
        {
            if (numOneInt % 2 == 0)
            {
                return $"{numOneInt} is an EVEN number.";
            }

            return $"{numOneInt} is an ODD number.";
        }
        else
        {
            return "Error: Please enter an integer number.";
        }
    }
}