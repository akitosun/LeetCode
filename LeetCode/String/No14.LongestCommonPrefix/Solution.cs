using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String.No14.LongestCommonPrefix
{
    /// <summary>
    ///   Write a function to find the longest common prefix string amongst an array of strings.
    ///   If there is no common prefix, return an empty string "".
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// Horizontal scanning
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string LongestCommonPrefixByHorizontalScanning(string[] input)
        {
            if (input.Length == 0) return "";
            // step 1. let first input array element be common prefix
            var prefix = input[0];
            // step 2. start from second input array element to compare
            for (int i = 1; i < input.Length; i++)
            {
                // step 3. cut one char from common prefix string end and re compare again until prefix found in element index 0 or common prefix become empty
                while (input[i].IndexOf(prefix)!=0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == string.Empty)
                    {
                        return string.Empty;
                    }
                }
            }

            return prefix;
        }
        /// <summary>
        /// Vertical scanning
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string LongestCommonPrefixByVerticalScanning(string[] input)
        {
            var prefix = string.Empty;
            var minimumlength = input.Min(x => x.Length);
            // step 1. start from 0 to minimumlength
            for (int i = 0; i < minimumlength; i++)
            {
                // step 2. define 1 char from first input array element and traverse
                var c = input[0].ToCharArray()[i];
                foreach (var word in input)
                {
                    // compare char
                    if (word.ToCharArray()[i] != c)
                    {
                        return prefix;
                    }
                }

                prefix += c;
            }

            return prefix;
        }
    }
}
