namespace Leetcode;
// https://leetcode.com/problems/plus-one/
public class PlusOne
{
    public int[] Solution(int[] digits)
    {
        int dLength = digits.Count();
        int arrayLength = 0;

        bool arrSizeUp = true;
        foreach(int a in digits)
        {
            if (a != 9)
            {
                arrSizeUp = false;
            }
        }

        if (arrSizeUp)
        {
            arrayLength = dLength + 1;
        }
        else
        {
            arrayLength = dLength;
        }

        int[] solution = new int[arrayLength];
        int previousValue = 0;
        // go backwards through array
        for (int i = dLength - 1; i >= 0; i--)
        {
            if (i == dLength - 1)
            {
                solution[i] = digits[i] + 1;
                previousValue = solution[i];
                if (solution[i] == 10)
                {
                    solution[i] = 0;
                }
            }
            else
            {
                if (previousValue == 10)
                {
                    solution[i] = digits[i] + 1;
                    previousValue = solution[i];
                    if (solution[i] == 10)
                    {
                        solution[i] = 0;
                    }
                }

                else
                {
                    solution[i] = digits[i];
                    previousValue = solution[i];
                }
            }
        }

        if (solution[0] == 0)
        {
            solution[0] = 1;
        }

        Console.WriteLine(String.Join(", ", solution));
        return solution;

    }
}