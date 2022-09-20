namespace Leetcode;

// https://leetcode.com/problems/valid-parentheses/
public class ValidParen
{
    // current fail
    // example '){'
    public bool Solution(string s)
    {
        bool solution = false;

        char[] left = new char[]{'{', '[', '('};
        char[] right = new char[]{'}', ']', ')'};

        List<char> allParen = new List<char>();

        // other seperate solution:
        // only would need to iterate once
        // save each to a new char[]
        // continue as long as left char
        // if right char, compare to latest left char

        if (s.Length % 2 == 0)
        {
            foreach (char paren in s)
            {
                // if it is a right paren
                if (right.Contains(paren))
                {
                    // check if the allParen.Last is a match by checking its index in left
                    // need to find IndexOf of paren in left & right
                    if (allParen.Count == 0)
                    {
                        solution = false;
                        break;
                    }

                    char latestEntry = allParen.Last();
                    if (Array.IndexOf(left, latestEntry) == Array.IndexOf(right, paren))
                    {
                        // then it is a match. Remove latestEntry to clear matches
                        allParen.RemoveAt(allParen.Count - 1);
                        solution = true;
                    }
                    else
                    {
                        solution = false;
                        break;
                    }
                }
                else
                {
                    allParen.Add(paren);
                }
            }
        }
        else
        {
            solution = false;
        }

        // if there is remainder, then not all matches
        if (allParen.Count != 0)
        {
            solution = false;
        }

        return solution;
    }
}
