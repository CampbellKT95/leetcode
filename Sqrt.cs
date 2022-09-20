namespace Leetcode;
// https://leetcode.com/problems/sqrtx
// since # is truncated, just need to find a number that ^2 into our given int
public class Sqrt
{
	// example 100 -> 10
    public int Solution(int x)
    {
		double solution = 0;

		// constantly check midpoint with upper bounds?
		double upper = x;
		double mid = 0;
		double lower = 0;

		while (solution == 0)
		{
			mid = (upper + lower) / 2;

			if (mid * mid == x)
			{
				solution = mid;
			}

			else if (mid * mid > x)
			{
				// x will be less than the midpoint
				upper = mid;
			}

			else if (mid * mid < x)
			{
				lower = mid;
			}
		}

		int answer = Convert.ToInt32(solution);
		return answer;
	}
}
