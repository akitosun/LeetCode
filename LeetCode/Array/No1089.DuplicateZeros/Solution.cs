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
            var zeros = arr.Count(x=>x==0);
            
            var len = arr.Length - 1;

            while (len > 0 && zeros > 0)
            {
                if (len + zeros <= arr.Length - 1)
                {
                    arr[len + zeros] = arr[len];
                }

                if (arr[len] == 0)
                {
                    zeros--;
                }

                arr[len] = 0;
                len--;
            }
        }
    }
}
