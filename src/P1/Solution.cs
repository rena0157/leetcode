using System;

namespace P1
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 1; j < nums.Length; j++)
                {
                    if (i == j)
                        continue;
                    
                    if (nums[i] + nums[j] == target)
                        return new[] { i, j };
                }
            }

            throw new Exception("No Solution Found");
        }
    }
}