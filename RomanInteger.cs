namespace Leetcode;

// https://leetcode.com/problems/roman-to-integer/
public class RomanInteger
{
    // for improvement: think of Rich's solution with the roman letters in an array that can be referenced
    public int Solution(string s)
    {
        int solution = 0;

        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine(s[i]);

            
            if (s[i] == char.Parse("M"))
            {
                solution += 1000;
            }

            else if (s[i] == char.Parse("D"))
            {
                solution += 500;
            }

            else if (s[i] == char.Parse("C"))
            {
                try
                {
                    if (s[i + 1] == char.Parse("D") || s[i+1] == char.Parse("M"))
                    {
                        solution -= 100;
                    }
                    else
                    {
                        solution += 100;
                    }
                }
                catch 
                {
                    solution += 100;
                }

            }

            else if (s[i] == char.Parse("L"))
            {
                solution += 50;
            }

            else if (s[i] == char.Parse("X"))
            {
                try
                {
                    if (s[i + 1] == char.Parse("L") || s[i+1] == char.Parse("C"))
                    {
                        solution -= 10;
                    }
                    else
                    {
                        solution += 10;
                    }
                }
                catch {
                    solution += 10;
                }

            }
            else if (s[i] == char.Parse("V"))
            {
                solution += 5;
            }
            else
            {
                try
                {
                    if (s[i + 1] == char.Parse("X") || s[i+1] == char.Parse("V"))
                    {
                        solution -= 1;
                    }
                    else
                    {
                        solution += 1;
                    }
                }
                catch {
                    solution += 1;
                }

            }
            
            // Console.WriteLine(solution);
        }

        return solution;
    }
}