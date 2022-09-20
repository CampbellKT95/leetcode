namespace Leetcode;

public class LongestCommonPrefix
{
	public string Solution(string[] strs)
	{
		// EXAMPLE: [aaa, aa, aaa]
		// EXAMPLE 2: [flower, flow, flight]

		string solution = "";
		List<string> prefix = new List<string>();
	
        // order array from smallest to largest, then compare smallest vs other two
        Array.Sort(strs);

		if (strs.Length == 1)
		{
			solution = strs[0];
		}
		else{
			for (int i = 1; i < strs.Length; i++)
			{
				solution = "";
				for(int j = 0; j < strs[0].Length; j++)
				{
					if(strs[0][j] == strs[i][j])
					{
						solution += strs[i][j];
					}
					else
					{
						break;
					}
				}
				prefix.Add(solution);
			}

			prefix.Sort();
			solution = prefix[0];
		}

		return solution;	
	}
}
