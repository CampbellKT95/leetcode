namespace Leetcode;

public class ArrayDup
{
    public int Solution(int[] nums)
    {
        // number of elements remaining after removal of dups
        int k = 0;

        List<int> uniqueValues = new List<int>();
        int numOfDups = 0;


        foreach (int num in nums)
        {
            if (uniqueValues.Any(uniqueItem => uniqueItem == num))
            {
                numOfDups++;
            }
            else
            {
                uniqueValues.Add(num);
            }
        }

        k = nums.Length - numOfDups;
        for (int i = 0; i < uniqueValues.Count; i++)
        {
            nums[i] = uniqueValues[i];
        }

        //Console.WriteLine(k);
        //Console.WriteLine($"{string.Join(", ", nums)}");
        return k;
    }
}