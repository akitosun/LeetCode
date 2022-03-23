using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable.No1.TwoSum
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    /// </summary>
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //O(n^2)
            //var result = new int[2];
            //for (var i = 0; i < nums.Length; i++)
            //{
            //    var assert = target - nums[i];
            //    for (var j = i+1; j < nums.Length; j++)
            //    {

            //        if (nums[j] == assert)
            //        {
            //            result[0] = i;
            //            result[1] = j;
            //        }
            //    }
            //}
            //return result;

            //O(n)
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (dict.ContainsKey(diff))
                    return new int[] { dict[diff],i };
                else
                    dict.TryAdd(nums[i], i);
            }
            return new int[] { 0, 0 };

        }
    }
}
