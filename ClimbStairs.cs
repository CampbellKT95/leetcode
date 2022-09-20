namespace Leetcode;

// https://leetcode.com/problems/climbing-stairs/
public class ClimbStairs
{
	public int Solution(int n)
	{
		int solution = 0;
		int fp = 0;
		int sp = 1;
		// it is basically fib lmao
		// how would I have figured this out myself??
		
		for (int 0 = 1; i < n; i++)
		{
			solution = fp + sp;
			fp = sp;
			sp = solution;
		}


		return solution;
	}
}
