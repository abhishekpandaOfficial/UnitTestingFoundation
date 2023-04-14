namespace Sparky;

public class Calculator
{
    public List<int> NumberRange { get; set; }

    // Adning 2 Numbers
    public int  AddNumbers(int x, int y)
    {
        return x + y;
    }

    // Checking the Given Number is Odd Number or not

    public bool IsOddNumber(int a)
    {
        return a % 2 != 0;
    }


    

    public List<int> GetOddRange(int min, int max)
    {
        if(NumberRange != null)
        {
            for (int i = min; i <= max; i++)
            {
                if (i % 2 != 0)
                {
                    NumberRange.Add(i);
                }
                else {

                    return NumberRange;
                }
            }
            
        }

        return NumberRange;

    }

}

