using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array.No283.MoveZeroes
{
    /// <summary>
    /// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    /// Note that you must do this in-place without making a copy of the array.
    /// </summary>
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            var pos = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    pos++;
                    continue;
                }
                else
                {
                    var temp = nums[i - pos];
                    nums[i - pos] = nums[i];
                    nums[i] = temp;
                }
            }
        }
    }
}
