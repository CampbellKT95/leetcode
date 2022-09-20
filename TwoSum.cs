using System;
using System.Collections;

namespace Leetcode;
// https://leetcode.com/problems/two-sum/
public class TwoSum
{
    // for improvement, how can we avoid O(N)^2
    public int[] Solution(int[] nums, int target)
    {
        int[] solution = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for(int y = 0; y < nums.Length; y++)
            {   
                if (i == y)
                {
                    continue;
                }

                else if (nums[i] + nums[y] == target)
                {
                    solution[0] = i;
                    solution[1] = y;
                }
            }

        }
        
        Console.WriteLine($"{string.Join(", ", solution)}");
        return solution;
    }
}