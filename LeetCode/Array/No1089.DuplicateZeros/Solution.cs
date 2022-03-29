using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array.No1089.DuplicateZeros
{
    /// <summary>
    ///Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.
    /// Note that elements beyond the length of the original array are not written.Do the above modifications to the input array in place and do not return anything.
    /// </summary>
    public class Solution
    {
        public void DuplicateZeros(int[] arr)
        {
            var list = new List<int>();
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    list.Add(0);
                }
                list.Add(arr[i]);
                arr[i] = list[i];
            }
        }
    }
}
