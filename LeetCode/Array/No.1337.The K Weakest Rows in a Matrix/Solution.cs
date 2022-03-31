using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array.No._1337.The_K_Weakest_Rows_in_a_Matrix
{
    /// <summary>
    /// You are given an m x n binary matrix mat of 1's (representing soldiers) and 0's (representing civilians). The soldiers are positioned in front of the civilians. That is, all the 1's will appear to the left of all the 0's in each row.
    /// A row i is weaker than a row j if one of the following is true:
    /// The number of soldiers in row i is less than the number of soldiers in row j.
    /// Both rows have the same number of soldiers and i<j
    /// Return the indices of the k weakest rows in the matrix ordered from weakest to strongest.
    /// </summary>
    public class Solution
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {
            Dictionary<int, int> soldier = new Dictionary<int, int>();
            for (int i = 0; i < mat.Length; i++)
            {
                int count = mat[i].ToList().Where(x => x == 1).Count();
                soldier.Add(i, count);
            }

            int[] temp = soldier.OrderBy(x => x.Value).Select(x => x.Key).Take(k).ToArray();
            if (temp.Length == 0)
                return new int[] { 0 };
            return temp;
        }
    }
}
